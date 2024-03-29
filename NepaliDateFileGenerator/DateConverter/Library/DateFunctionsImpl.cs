﻿using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateConverter.Core.Library
{
    public class DateFunctionsImpl : DateFunctions
    {
        NepaliDateData nepaliDateArray;
        
        public DateFunctionsImpl(NepaliDateData _nepaliDateArray)
        {
            nepaliDateArray = _nepaliDateArray;
        }

        public DateTime FormatUnixTime(double timestamp)
        {
            DateTime startUnixTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return startUnixTime.AddSeconds(timestamp).ToUniversalTime();
        }

        public string GetDayOfWeek(int day)
        {
            switch ((day))
            {
                case 1:
                    return "Sunday";
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                default:
                    return null;
            }
        }

        public string GetEnglishMonth(int month)
        {
            switch ((month))
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return null;
            }
        }

        public string GetNepaliMonth(int month)
        {
            switch ((month))
            {
                case 1:
                    return "Baisakh";
                case 2:
                    return "Jestha";
                case 3:
                    return "Ashad";
                case 4:
                    return "Shrawan";
                case 5:
                    return "Bhadra";
                case 6:
                    return "Ashwin";
                case 7:
                    return "Kartik";
                case 8:
                    return "Mangsir";
                case 9:
                    return "Poush";
                case 10:
                    return "Magh";
                case 11:
                    return "Falgun";
                case 12:
                    return "Chaitra";
                default:
                    return null;
            }
        }

        public double GetUnixTimestamp(DateTime gDate)
        {
            //Overloads
            //create Timespan by subtracting the value provided from the Unix Epoch
            TimeSpan span = (gDate - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime());
            //return the total seconds (which is a UNIX timestamp)
            return span.TotalSeconds;
        }

        public bool IsLeapYear(int english_year)
        {
            //Calculates whether a english year is leap year or not
            if ((english_year % 100 == 0))
            {
                if ((english_year % 400 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((english_year % 4 == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int getLastDayOfMonthNep(int year, int month)
        {
            int[][] bs = null;
            bs = new int[91][];
            if ((year > 1999))
            {
                year = year - 2000;
            }
            //The following data allows the coversion between the range 1944-2033 (AD) only

            bs[0] = new int[]{
            2000,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[1] = new int[]{
            2001,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[2] = new int[]{
            2002,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[3] = new int[]{
            2003,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[4] = new int[]{
            2004,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[5] = new int[]{
            2005,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[6] = new int[]{
            2006,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[7] = new int[]{
            2007,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[8] = new int[]{
            2008,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[9] = new int[]{
            2009,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[10] = new int[]{
            2010,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[11] = new int[]{
            2011,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[12] = new int[]{
            2012,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[13] = new int[]{
            2013,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[14] = new int[]{
            2014,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[15] = new int[]{
            2015,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[16] = new int[]{
            2016,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[17] = new int[]{
            2017,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[18] = new int[]{
            2018,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[19] = new int[]{
            2019,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[20] = new int[]{
            2020,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[21] = new int[]{
            2021,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[22] = new int[]{
            2022,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[23] = new int[]{
            2023,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[24] = new int[]{
            2024,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[25] = new int[]{
            2025,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[26] = new int[]{
            2026,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[27] = new int[]{
            2027,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[28] = new int[]{
            2028,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[29] = new int[]{
            2029,
            31,
            31,
            32,
            31,
            32,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[30] = new int[]{
            2030,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[31] = new int[]{
            2031,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[32] = new int[]{
            2032,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[33] = new int[]{
            2033,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[34] = new int[]{
            2034,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[35] = new int[]{
            2035,
            30,
            32,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[36] = new int[]{
            2036,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[37] = new int[]{
            2037,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[38] = new int[]{
            2038,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[39] = new int[]{
            2039,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[40] = new int[]{
            2040,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[41] = new int[]{
            2041,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[42] = new int[]{
            2042,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[43] = new int[]{
            2043,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[44] = new int[]{
            2044,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[45] = new int[]{
            2045,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[46] = new int[]{
            2046,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[47] = new int[]{
            2047,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[48] = new int[]{
            2048,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[49] = new int[]{
            2049,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[50] = new int[]{
            2050,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[51] = new int[]{
            2051,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[52] = new int[]{
            2052,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[53] = new int[]{
            2053,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[54] = new int[]{
            2054,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[55] = new int[]{
            2055,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[56] = new int[]{
            2056,
            31,
            31,
            32,
            31,
            32,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[57] = new int[]{
            2057,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[58] = new int[]{
            2058,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[59] = new int[]{
            2059,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[60] = new int[]{
            2060,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[61] = new int[]{
            2061,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[62] = new int[]{
            2062,
            30,
            32,
            31,
            32,
            31,
            31,
            29,
            30,
            29,
            30,
            29,
            31
        };

            bs[63] = new int[]{
            2063,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[64] = new int[]{
            2064,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[65] = new int[]{
            2065,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[66] = new int[]{
            2066,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            29,
            31
        };

            bs[67] = new int[]{
            2067,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[68] = new int[]{
            2068,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[69] = new int[]{
            2069,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[70] = new int[]{
            2070,
            31,
            31,
            31,
            32,
            31,
            31,
            29,
            30,
            30,
            29,
            30,
            30
        };

            bs[71] = new int[]{
            2071,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[72] = new int[]{
            2072,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[73] = new int[]{
            2073,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            31
        };

            bs[74] = new int[]{
            2074,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[75] = new int[]{
            2075,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[76] = new int[]{
            2076,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[77] = new int[]{
            2077,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            29,
            31
        };

            bs[78] = new int[]{
            2078,
            31,
            31,
            31,
            32,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[79] = new int[]{
            2079,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            29,
            30,
            29,
            30,
            30
        };

            bs[80] = new int[]{
            2080,
            31,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            29,
            30,
            30
        };

            bs[81] = new int[]{
            2081,
            31,
            31,
            32,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[82] = new int[]{
            2082,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[83] = new int[]{
            2083,
            31,
            31,
            32,
            31,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[84] = new int[]{
            2084,
            31,
            31,
            32,
            31,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[85] = new int[]{
            2085,
            31,
            32,
            31,
            32,
            30,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[86] = new int[]{
            2086,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[87] = new int[]{
            2087,
            31,
            31,
            32,
            31,
            31,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[88] = new int[]{
            2088,
            30,
            31,
            32,
            32,
            30,
            31,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[89] = new int[]{
            2089,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            bs[90] = new int[]{
            2090,
            30,
            32,
            31,
            32,
            31,
            30,
            30,
            30,
            29,
            30,
            30,
            30
        };

            return (bs[year][month]);
        }
    }
}
