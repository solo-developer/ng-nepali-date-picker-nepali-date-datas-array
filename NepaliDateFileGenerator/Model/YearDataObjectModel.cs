using System;
using System.Collections.Generic;
using System.Text;

namespace NepaliDateFileGenerator.Model
{
    public class DayObjectDataModel
    {
        public string np { get; set; }
        public string en { get; set; }
        public string tithi { get; set; }
        public string day { get; set; }
        public string bar { get; set; }
        public bool holiday { get; set; }
    }

    public enum Month
    {
        Baishakh = 1,
        Jestha = 2,
        Ashadh = 3,
        Shrawan = 4,
        Bhadra = 5,
        Ashwin = 6,
        Kartik = 7,
        Mangsir = 8,
        Poush = 9,
        Magh = 10,
        Falgun = 11,
        Chaitra = 12
    }

    public enum Days
    {
        sun = 1,
        mon = 2,
        tue = 3,
        wed = 4,
        thu = 5,
        fri = 6,
        sat = 7,
    }

    public enum Bars
    {
        आइत = 1,
        सोम = 2,
        मगल = 3,
        बुध = 4,
        बिहि = 5,
        शुक्र = 6,
        शनि = 7,
    }

    public static class MonthExtensions
    {
        public static string getMonthName(this int month_number)
        {
            return ((Month)month_number).ToString();
        }
    }
    public static class DayExtensions
    {
        public static string getDayName(this int day_number)
        {
            return ((Days)day_number).ToString();
        }
    }

    public static class BarExtensions
    {
        public static string getBarName(this int bar_number)
        {
            return ((Bars)bar_number).ToString();
        }
    }

}
