using RestSharp;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.HTTPManager
{
    public class CadLatestCallManager
    {
        private readonly IRestClient _client;
        private IRestResponse _response;

        public CadLatestCallManager()
        {
           
        }

        internal string GetAllCadData()
        {
            throw new NotImplementedException();
        }
    }
}