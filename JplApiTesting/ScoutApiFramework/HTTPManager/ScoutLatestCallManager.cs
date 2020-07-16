using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Scout.HTTPManager
{
    public class ScoutLatestCallManager : BaseCallManager
    {
        public ScoutLatestCallManager()
        {
            client = new RestClient(ScoutConfigReader.ScoutUrl);
        }

        public string AllScoutData => CreateGetRequest("/");

        public string GetScoutDataForGivenName(string name) =>
            CreateGetRequest($"?{ScoutConfigReader.TdesParam}{name}");

        public string GetScoutEphemerisData(string name, string date) =>
            CreateGetRequest($"?{ScoutConfigReader.TdesParam}{name}&" +
                $"{ScoutConfigReader.DateParam}{date}");

        public Dictionary<string, string> GetContentTypeHeader() =>
            TestTools.GetContentTypeHeader(response.Headers);
    }
}