using RestSharp;
using System.Collections.Generic;

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

        private string CreateGetRequest(string RequestString)
        {
            RestRequest request = new RestRequest(RequestString);
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        internal Dictionary<string, string> GetContentTypeHeader()
        {
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();

            foreach (var item in _response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            return HeadersDict;
        }

        internal string GetAllCadData() => CreateGetRequest($"?body=All");
        internal string GetLimitData(int limit) => CreateGetRequest($"?body=All&limit={limit}");
        internal string GetSpecificBodyData(string body) => CreateGetRequest($"?body={body}");
        internal string GetSpecificClassData(string classRequest) => CreateGetRequest($"?body=All&class={classRequest}");
    }
}