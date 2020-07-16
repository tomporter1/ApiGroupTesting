using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadSpecificBodyService : CadService
    {
        public CadSpecificBodyService(Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams)
        {
            if (requestParams[RequestParametersTypes.Body].Data == string.Empty)
                throw new ArgumentException("The body cannot be an empty string");

            ResponseData = callManager.MakeRequest(requestParams);

            Setup();
        }
    }
}