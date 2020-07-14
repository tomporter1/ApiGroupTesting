using RestSharp;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Scout.HTTPManager
{
    public class ScoutLatestCallManager
    {
        private readonly IRestClient _client;

        public ScoutLatestCallManager()
        {
            _client = new RestClient(ScoutConfigReader.ScoutUrl);
        }

        public string GetAllScoutData()
        {
            var request = new RestRequest();
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}