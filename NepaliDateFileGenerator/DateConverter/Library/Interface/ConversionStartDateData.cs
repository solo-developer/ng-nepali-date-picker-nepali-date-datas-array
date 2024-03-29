﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DateConverter.Core.Library.Interface
{
    public interface ConversionStartDateData
    {
        Tuple<int[], int[], int> getClosestEnglishDateAndNepaliDate(DateTime english_date);

        Tuple<int, int[]> getClosestEnglishDateAndNepaliDateToAD(int nep_year);
    }
}
