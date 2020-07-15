using RestSharp;

namespace JplApiTesting.ApiObjectModels
{
    public abstract class BaseCallManager
    {
        protected IRestClient _client;
        protected IRestResponse response;

        public abstract string GetReport(in int numToShow = 0);
    }
}
