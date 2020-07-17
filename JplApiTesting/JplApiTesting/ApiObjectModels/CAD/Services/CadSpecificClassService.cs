using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadSpecificClassService : CadService
    {
        public CadSpecificClassService(Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams)
        {
            if (requestParams[RequestParametersTypes.Class].Data == string.Empty)
                throw new ArgumentException("The class cannot be an empty string");

            ResponseData = callManager.MakeRequest(requestParams);

            Setup();
        }
    }
}