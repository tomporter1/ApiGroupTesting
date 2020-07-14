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
                string[] minDateParts = minDateStr.Split('-');
                DateTime minDate = new DateTime(int.Parse(minDateParts[0]), int.Parse(minDateParts[1]), int.Parse(minDateParts[2]));
            }
            catch
            {
                throw new ArgumentException("The minimum date must be valid and in the form YYYY-MM-DD");
            }

            try
            {
                string[] maxDateParts = maxDateStr.Split('-');
                DateTime maxDate = new DateTime(int.Parse(maxDateParts[0]), int.Parse(maxDateParts[1]), int.Parse(maxDateParts[2]));
            }
            catch
            {
                throw new ArgumentException("The maximum date must be valid and in the form YYYY-MM-DD");
            }

            liveCurrent = callManager.GetDateFilteredData(minDateStr, maxDateStr);

            Setup();
        }

        public bool AllDatesAreWithinRange(string minDateStr, string maxDateStr)
        {
            //input dates are in the form YYYY-MM-DD
            string[] minDateParts = minDateStr.Split('-');
            string[] maxDateParts = maxDateStr.Split('-');
            DateTime minDate = new DateTime(int.Parse(minDateParts[0]), int.Parse(minDateParts[1]), int.Parse(minDateParts[2]));
            DateTime maxDate = new DateTime(int.Parse(maxDateParts[0]), int.Parse(maxDateParts[1]), int.Parse(maxDateParts[2]));

            foreach (List<string> dataItem in dto.LatestCAD.data)
            {
                //resp date format YYYY-MMM-DD where MMM is the month name abbreviation
                string[] respDateParts = dataItem[3].Substring(0, 11).Split('-');
                respDateParts[1] = MonthNameToNum(respDateParts[1]);

                DateTime respDate = new DateTime(int.Parse(respDateParts[0]), int.Parse(respDateParts[1]), int.Parse(respDateParts[2]));

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