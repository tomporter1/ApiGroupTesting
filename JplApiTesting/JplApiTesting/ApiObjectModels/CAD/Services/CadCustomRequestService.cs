using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadCustomRequestService : CADService
    {
        public CadCustomRequestService(string requestStr)
        {
            if (requestStr == string.Empty)
                throw new ArgumentException("The request cannot be an empty string");

            liveCurrent = callManager.GetCustomRequestData(requestStr);

            dto.DeserializeCADError(liveCurrent);
            json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
        }
    }
}