using DateConverter.Core;
using NepaliDateFileGenerator.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NepaliDateFileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var responseObject = new Dictionary<string, object>();

            var yearObject = new Dictionary<string, object>();

            var dateConverterService = DateConverter.Core.Service_Factory.DateConverterFactory.getDateConverterService();

            DateTime englishStartDate = dateConverterService.ToAD("01/01/2002").getFormattedDate();

            Console.WriteLine($"Starting English Date: {englishStartDate}");

            var yearsList = new List<YearList>();
            var monthsList = new List<MonthList>();

            var monthDaysData = new List<DayObjectDataModel>();

            while (englishStartDate <= new DateTime(2032, 12, 12))
            {
                NepaliDate nepaliDate = dateConverterService.ToBS(englishStartDate);

                monthDaysData.Add(new DayObjectDataModel()
                {
                    np = nepaliDate.npDay.ToString(),
                    en = englishStartDate.Day.ToString(),
                    bar = nepaliDate.dayNumber.getBarName(),
                    day = nepaliDate.dayNumber.getDayName(),
                    holiday = nepaliDate.dayNumber == 7,
                });

                if (monthsList.Where(a => a.month == nepaliDate.npMonth).SingleOrDefault() == null)
                {
                    monthsList.Add(new MonthList
                    {
                        month = nepaliDate.npMonth,
                        is_closed = false
                    });
                }

                if (yearsList.Where(a => a.year == nepaliDate.npYear).SingleOrDefault() == null)
                {
                    yearsList.Add(new YearList
                    {
                        year = nepaliDate.npYear,
                        is_closed = false
                    });
                }

                bool isLastDayOfMonth = nepaliDate.npDaysInMonth == nepaliDate.npDay;
                if (isLastDayOfMonth)
                {
                    monthsList.Where(a => a.month == nepaliDate.npMonth).Single().is_closed = true;

                    if (!yearObject.Keys.Contains((nepaliDate.npMonth).getMonthName()))
                    {
                        yearObject.Add((nepaliDate.npMonth).getMonthName(), monthDaysData);
                        monthDaysData = new List<DayObjectDataModel>();
                    }
                }

                bool isLastDayOfYear = nepaliDate.npMonth == 12 && isLastDayOfMonth;

                if (isLastDayOfYear)
                {
                    yearsList.Where(a => a.year == nepaliDate.npYear).Single().is_closed = true;

                    if (!responseObject.Keys.Contains((nepaliDate.npYear).ToString()))
                    {
                        responseObject.Add((nepaliDate.npYear).ToString(), yearObject);
                        yearObject = new Dictionary<string, object>();
                    }
                }

                englishStartDate = englishStartDate.AddDays(1);
            }
            string jsonData = JsonConvert.SerializeObject(responseObject);
            //create a text file
            string path = @"G:\YearDatas\datas.json";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(jsonData);
                }
            }

            Console.Beep(15000, 1000);
            Console.WriteLine("Finished");
        }
    }
}
