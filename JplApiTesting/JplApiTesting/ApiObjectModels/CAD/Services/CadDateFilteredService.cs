using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadDateFilteredService : CadService
    {
        public CadDateFilteredService(string minDateStr, string maxDateStr)
        {
            //input dates are in the form YYYY-MM-DD
            if (minDateStr == string.Empty || maxDateStr == string.Empty)
                throw new ArgumentException("The date cannot be an empty string");
            
            try
            {
                DateParser(minDateStr);
            }
            catch
            {
                throw new ArgumentException("The minimum date must be valid and in the form YYYY-MM-DD");
            }

            try
            {
                DateParser(maxDateStr);
            }
            catch
            {
                throw new ArgumentException("The maximum date must be valid and in the form YYYY-MM-DD");
            }

            liveCurrent = callManager.GetDateFilteredData(minDateStr, maxDateStr);

            Setup();
        }

        private static DateTime DateParser(string date)
        {
            string[] dateParts = date.Split('-');
            if (!int.TryParse(dateParts[1], out int result))
                dateParts[1] = MonthNameToNum(dateParts[1]);

            return new DateTime(int.Parse(dateParts[0]), int.Parse(dateParts[1]), int.Parse(dateParts[2]));
        }

        public bool AllDatesAreWithinRange(string minDateStr, string maxDateStr)
        {
            //input dates are in the form YYYY-MM-DD
            DateTime minDate = DateParser(minDateStr);
            DateTime maxDate = DateParser(maxDateStr);

            foreach (List<string> dataItem in dto.LatestCAD.data)
            {
                //resp date format YYYY-MMM-DD where MMM is the month name abbreviation               
                DateTime respDate = DateParser(dataItem[3].Substring(0, 11));

                if (respDate < minDate || respDate > maxDate)
                    return false;
            }
            return true;
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
    }
}