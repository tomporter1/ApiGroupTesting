using JplApiTesting.ApiObjectModels.DateTimeConstants;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadDateFilteredService : CadService
    {
        public CadDateFilteredService(Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams)
        {
            //input dates are in the form YYYY-MM-DD
            if (requestParams[RequestParametersTypes.MinDate].Data == string.Empty || requestParams[RequestParametersTypes.MaxDate].Data == string.Empty)
                throw new ArgumentException("The date cannot be an empty string");

            try
            {
                DateTools.DateParser(requestParams[RequestParametersTypes.MinDate].Data);
            }
            catch
            {
                throw new ArgumentException("The minimum date must be valid and in the form YYYY-MM-DD");
            }

            try
            {
                DateTools.DateParser(requestParams[RequestParametersTypes.MaxDate].Data);
            }
            catch
            {
                throw new ArgumentException("The maximum date must be valid and in the form YYYY-MM-DD");
            }

            ResponseData = callManager.MakeRequest(requestParams);

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