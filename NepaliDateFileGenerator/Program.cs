using DateConverter.Core;
using NepaliDateFileGenerator.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace NepaliDateFileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearObject = new Dictionary<string, object>();

            var dateConverterService = DateConverter.Core.Service_Factory.DateConverterFactory.getDateConverterService();

            DateTime englishStartDate = dateConverterService.ToAD("01/01/2002").getFormattedDate();

            Console.WriteLine($"Starting English Date: {englishStartDate}");

            List<int> yearsList = new List<int>();
            List<int> monthsList = new List<int>();

            var monthDaysData = new List<DayObjectDataModel>();

            while (englishStartDate <= new DateTime(2033, 12, 12))
            {
                NepaliDate nepaliDate = dateConverterService.ToBS(englishStartDate);
                bool isMonthEnded = monthsList.Contains(nepaliDate.npMonth - 1);

                bool isYearEnded = yearsList.Contains(nepaliDate.npYear - 1);
                if (isYearEnded)
                {
                    yearsList.Remove(nepaliDate.npYear - 1);
                    string jsonData = JsonConvert.SerializeObject(yearObject);
                    //create a text file
                    string path = @"G:\YearDatas\" + nepaliDate.npYear + ".json";
                    if (!File.Exists(path))
                    {
                        File.Create(path).Dispose();

                        using (TextWriter tw = new StreamWriter(path))
                        {
                            tw.WriteLine(jsonData);
                        }
                    }

                    //   Console.WriteLine($"Year: {nepaliDate.npYear - 1} : {jsonData}");
                }

                if (isMonthEnded)
                {
                    yearObject.Add((nepaliDate.npMonth - 1).getMonthName(), monthDaysData);
                    monthsList.Remove(nepaliDate.npMonth - 1);
                    monthDaysData.Clear();
                }
                if (!yearsList.Contains(nepaliDate.npYear))
                {
                    yearObject = new Dictionary<string, object>();

                    //add an object
                    yearsList.Add(nepaliDate.npYear);
                }

                if (!monthsList.Contains(nepaliDate.npMonth))
                {
                    monthsList.Add(nepaliDate.npMonth);
                }

                monthDaysData.Add(new DayObjectDataModel()
                {
                    np = nepaliDate.npDay.ToString(),
                    en = englishStartDate.Day.ToString(),
                    bar = nepaliDate.dayNumber.getBarName(),
                    day = nepaliDate.dayNumber.getDayName(),
                    holiday = nepaliDate.dayNumber == 7,
                });


                englishStartDate = englishStartDate.AddDays(1);
            }
            Console.WriteLine("Finished");
        }
    }
}
