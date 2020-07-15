using JplApiTesting.ApiObjectModels.DateTimeConstants;
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
                DateTools.DateParser(minDateStr);
            }
            catch
            {
                throw new ArgumentException("The minimum date must be valid and in the form YYYY-MM-DD");
            }

            try
            {
                DateTools.DateParser(maxDateStr);
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
            DateTime minDate = DateTools.DateParser(minDateStr);
            DateTime maxDate = DateTools.DateParser(maxDateStr);

            foreach (List<string> dataItem in dto.LatestCAD.data)
            {
                //resp date format YYYY-MMM-DD where MMM is the month name abbreviation               
                DateTime respDate = DateTools.DateParser(dataItem[3].Substring(0, 11));

                if (respDate < minDate || respDate > maxDate)
                    return false;
            }
            return true;
        }
    }
}