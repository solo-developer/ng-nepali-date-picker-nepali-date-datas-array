using System;
using System.Collections.Generic;
using System.Text;

namespace DateConverter.Core.Library.Interface
{
    public interface FiscalYearFunctions
    {
        string getLastDateOfFiscalYear(int fiscal_year);
        int getFiscalYear(DateTime givenDate);
        DateTime getStartDateOfFiscalYear(int fiscal_year);
    }
}
