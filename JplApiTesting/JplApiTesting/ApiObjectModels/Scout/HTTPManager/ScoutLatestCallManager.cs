using RestSharp;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Scout.HTTPManager
{
    public class ScoutLatestCallManager
    {
        private readonly IRestClient _client;
        private IRestResponse _response;

        public ScoutLatestCallManager()
        {

        }

        internal string GetAllCadData()
        {
            throw new NotImplementedException();
        }
    }
}