using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Scout.HTTPManager
{
    public class ScoutLatestCallManager
    {
        private readonly IRestClient _client;
        private IRestResponse _response;

        public ScoutLatestCallManager()
        {
            _client = new RestClient(ScoutConfigReader.ScoutUrl);
        }

        public string GetAllScoutData()
        {
            var request = new RestRequest();
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        public string GetScoutDataForGivenName(string objectName)
        {
            var request = new RestRequest($"?tdes={objectName}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }
        public string GetScoutEphemerisData(string Name,string date)
        {
            var request = new RestRequest($"?tdes={Name}&eph-start={date}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        public Dictionary<string, string> GetContentTypeHeader()
        {
            Dictionary<string, string> HeaderDict = new Dictionary<string, string>();
            foreach (var item in _response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeaderDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            return HeaderDict;
        }
    }
}