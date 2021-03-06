﻿using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.SBDB.HTTPManager
{
    public class SbdbCallManager : BaseCallManager
    {
        public SbdbCallManager()
        {
            client = new RestClient(SbdbConfigReader.BaseUrl);
        }

        internal string GetSpecificBodyData(string bodyName) => CreateGetRequest($"?sstr={bodyName}");

        internal string GetCustomRequestData(string requestStr) => CreateGetRequest(requestStr);

        internal Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);
    }
}