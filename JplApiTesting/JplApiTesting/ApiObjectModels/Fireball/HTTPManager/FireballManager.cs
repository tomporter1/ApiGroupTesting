using JplApiTesting.ApiObjectModels;
using RestSharp;

namespace JplApiTesting.HTTPManager
{
    public class FireballManager
    {
        private readonly IRestClient _client;

        public FireballManager()
        {
            _client = new RestClient(FireballConfigReader.BaseUrl);
        }

        public string GetReport()
        {
            IRestRequest request = new RestRequest();
            IRestResponse response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}