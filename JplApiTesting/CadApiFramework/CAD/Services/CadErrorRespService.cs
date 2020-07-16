using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadErrorRespService : CadService
    {
        public CadErrorRespService(Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams)
        {
            if (requestParams.Count == 0)
                throw new ArgumentException("The request cannot be an empty string");

            ResponseData = callManager.MakeRequest(requestParams);

            dto.DeserializeCADError(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }

        public CadErrorRespService(string request)
        {
            if (request == string.Empty)
                throw new ArgumentException("The request cannot be an empty string");

            ResponseData = callManager.GetCustomRequestData(request);

            dto.DeserializeCADError(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
    }
}