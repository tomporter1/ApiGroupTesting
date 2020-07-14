using RestSharp;

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
            RestRequest request = new RestRequest($"?body=All");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        internal string GetLimitData(int limit)
        {
            RestRequest request = new RestRequest($"?body=All&limit={limit}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        internal string GetSpecificBodyData(string body)
        {
            RestRequest request = new RestRequest($"?body={body}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }
        
        internal string GetSpecificClassData(string classRequest)
        {
            RestRequest request = new RestRequest($"?body=All&class={classRequest}");
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }
    }
}