using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadErrorRespService : CadService
    {
        public CadErrorRespService(string requestStr)
        {
            if (requestStr == string.Empty)
                throw new ArgumentException("The request cannot be an empty string");

            ResponceData = callManager.GetCustomRequestData(requestStr);

            dto.DeserializeCADError(ResponceData);
            JObjectResponce = JsonConvert.DeserializeObject<JObject>(ResponceData);
        }
    }
}