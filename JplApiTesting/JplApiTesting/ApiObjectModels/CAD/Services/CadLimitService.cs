using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadLimitService : CadService
    {
        public CadLimitService(Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams)
        {
            if (int.Parse(requestParams[RequestParametersTypes.Limit].Data) < 0)
                throw new ArgumentException("The limit for the request cannot be negative");

            ResponseData = callManager.MakeRequest(requestParams);

            Setup();
        }
    }
}