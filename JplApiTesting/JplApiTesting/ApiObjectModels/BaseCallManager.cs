using RestSharp;

namespace JplApiTesting.ApiObjectModels
{
    public abstract class BaseCallManager
    {
        protected IRestClient _client;
        protected IRestResponse response;

        public virtual string GetReport(in int numToShow = 0)
        {
            return "";
        }

        protected virtual string CreateGetRequest(string RequestString)
        {
            RestRequest request = new RestRequest(RequestString);
            response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
