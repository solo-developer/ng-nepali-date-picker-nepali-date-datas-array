using DateConverter.Core.Library.Interface;
using System;

namespace DateConverter.Core.Library
{
    public class GetSplittedNepaliDatePartsImpl : GetSplittedNepaliDateParts
    {
        public Tuple<int, int, int> getNepaliDatePartsFrom(string nepali_date)
        {
            System.String[] userDateParts = nepali_date.Split(new[] { "/" }, StringSplitOptions.None);
            int yy = int.Parse(userDateParts[0]);
            int mm = int.Parse(userDateParts[1]);
            int dd = int.Parse(userDateParts[2]);
            return new Tuple<int, int, int>(yy, mm, dd);
        }
    }
}
