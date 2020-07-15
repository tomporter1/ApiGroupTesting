using RestSharp;

namespace JplApiTesting.ApiObjectModels.Fireball.HTTPManager
{
    public class FireballManager
    {
        private readonly IRestClient _client;

        public FireballManager()
        {
            _client = new RestClient(FireballConfigReader.BaseUrl);
        }

#warning Test this: if numToShow <= 0, there will be no limit

        public string GetReport(in int numToShow = 0)
        {
            IRestRequest request
                = (numToShow <= 0) ? new RestRequest() : new RestRequest($"limit={numToShow}");
            IRestResponse response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}