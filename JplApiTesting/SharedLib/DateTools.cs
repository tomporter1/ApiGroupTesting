using System;

namespace JplApiTesting.ApiObjectModels.DateTimeConstants
{
    public static class DateTools
    {
        public static DateTime DateParser(string date)
        {
            string[] dateParts = date.Split('-');
            if (!int.TryParse(dateParts[1], out int result))
                dateParts[1] = MonthNameToNum(dateParts[1]);

            return new DateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]));
        }

        private static string MonthNameToNum(string monthName)
        {
            switch (monthName)
            {
                case "Jan":
                    return "1";

                case "Feb":
                    return "2";

                case "Mar":
                    return "3";

                case "Apr":
                    return "4";

                case "May":
                    return "5";

                case "Jun":
                    return "6";

                case "Jul":
                    return "7";

                case "Aug":
                    return "8";

                case "Sep":
                    return "9";

                case "Oct":
                    return "10";

                case "Nov":
                    return "11";

                case "Dec":
                    return "12";

                default:
                    return "";
            }
        }

        public static class DateTimeConstants
        {
            public const char DateTimeSeparator = ' ';
            public const char DateSeparator = '-';
            public const char TimeSeparator = ':';

            public const int DateIndex = 0;
            public const int TimeIndex = 1;

            public const int YearIndex = 0;
            public const int MonthIndex = 1;
            public const int DayIndex = 2;

            public const int HourIndex = 0;
            public const int MinuteIndex = 1;
            public const int SecondIndex = 2;
        }
    }
}