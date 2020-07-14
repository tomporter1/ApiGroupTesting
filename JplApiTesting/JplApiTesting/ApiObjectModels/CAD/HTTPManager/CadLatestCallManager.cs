using RestSharp;
using System;

namespace JplApiTesting.ApiObjectModels.CAD.HTTPManager
{
    public class CadLatestCallManager
    {
        private readonly IRestClient _client;
        private IRestResponse _response;

        public CadLatestCallManager()
        {
            _client = new RestClient(CADConfigReader.BaseUrl);
        }

        internal string GetAllCadData()
        {
            RestRequest request = new RestRequest();
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        internal string GetLimitData(int limit)
        {
            RestRequest request = new RestRequest($"?limit={limit}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }
    }
}