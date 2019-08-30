using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateConverter.Core.Library
{
    using dateConverterService = DateConverter.Core.Library.Interface.DateConverter;
    public class FiscalYearFunctionsImpl : FiscalYearFunctions
    {
        dateConverterService dateConverter;
        NepaliDateData nepaliDateArray;
        public FiscalYearFunctionsImpl(dateConverterService _dateConverter,NepaliDateData _nepaliDateData)
        {
            dateConverter = _dateConverter;
            nepaliDateArray = _nepaliDateData;
        }
        public int getFiscalYear(DateTime givenDate)
        {
            // first find year
            if ((givenDate == null))
            {
                givenDate = DateTime.Now;
            }

            NepaliDate nepaliDate = dateConverter.ToBS(givenDate);
            int Month = nepaliDate.npMonth;
            int Day = nepaliDate.npDay;
            int Year = nepaliDate.npYear;
            if ((Month >= 4))
            {
                return Year;
            }
            else
            {
                return Year - 1;
            }
        }

        public string getLastDateOfFiscalYear(int fiscal_year)
        {
            if ((fiscal_year < 1000))
            {
                return "";
            }
            int return_year = fiscal_year + 1;
            return "03" + "-" + nepaliDateArray.getLastDayOfMonthNep(fiscal_year + 1, 3) + "-" + return_year;
        }

        public DateTime getStartDateOfFiscalYear(int fiscal_year)
        {
            return new System.DateTime(fiscal_year, 4, 1);
        }
    }
}
