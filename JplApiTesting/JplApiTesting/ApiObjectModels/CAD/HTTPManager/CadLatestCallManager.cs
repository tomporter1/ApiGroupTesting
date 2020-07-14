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

        private string CreateGetRequest(string RequestString)
        {
            RestRequest request = new RestRequest(RequestString);
            _response = _client.Execute(request, Method.GET);
            return _response.Content;
        }

        internal string GetAllCadData() => CreateGetRequest($"?body=All");
        internal string GetLimitData(int limit) => CreateGetRequest($"?body=All&limit={limit}");
        internal string GetSpecificBodyData(string body) => CreateGetRequest($"?body={body}");
        internal string GetSpecificClassData(string classRequest) => CreateGetRequest($"?body=All&class={classRequest}");
    }
}