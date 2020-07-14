using RestSharp;

namespace JplApiTesting.ApiObjectModels.Sentry.HTTPManager
{
    public class SentryCallManager
    {
        private readonly IRestClient _client;
        private IRestResponse _response;

        public SentryCallManager()
        {
            string thing = SentryConfigReader.BaseUrl;
            _client = new RestClient(thing);
        }

        public string GetSentryObjectInfo()
        {
            var request = new RestRequest();
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}