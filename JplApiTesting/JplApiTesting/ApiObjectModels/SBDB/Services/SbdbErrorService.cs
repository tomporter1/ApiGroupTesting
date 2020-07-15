using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.SBDB.Services
{
    public class SbdbErrorService : SbdbService
    {
        public SbdbErrorService(string requestStr)
        {
            if (requestStr == string.Empty)
                throw new ArgumentException("The request cannot be an empty string");

            ResponceData = callManager.GetCustomRequestData(requestStr);

            DTO.DeserializeSBDBError(ResponceData);
            JObjectResponce = JsonConvert.DeserializeObject<JObject>(ResponceData);
        }
    }
}