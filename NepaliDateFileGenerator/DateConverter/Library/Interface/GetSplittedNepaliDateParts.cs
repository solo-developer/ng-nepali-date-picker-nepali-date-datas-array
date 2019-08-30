using System;
using System.Collections.Generic;
using System.Text;

namespace DateConverter.Core.Library.Interface
{
    public interface GetSplittedNepaliDateParts
    {
       Tuple<int,int,int> getNepaliDatePartsFrom(string nepali_date);
    }
}
