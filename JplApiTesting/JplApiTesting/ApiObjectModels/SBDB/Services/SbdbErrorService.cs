﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JplApiTesting.ApiObjectModels.SBDB.Services
{
    public class SbdbErrorService : SbdbService
    {
        public SbdbErrorService(string requestStr)
        {
            if (requestStr == string.Empty)
                throw new ArgumentException("The request cannot be an empty string");

            ResponseData = callManager.GetCustomRequestData(requestStr);

            DTO.DeserializeSBDBError(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
    }
}