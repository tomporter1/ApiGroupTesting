using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.HTTPManager
{
    public class CadLatestCallManager : BaseCallManager
    {
        private readonly string _defaultBodyParam = $"{CADConfigReader.BodyParam}All";

        public CadLatestCallManager()
        {
            client = new RestClient(CADConfigReader.BaseUrl);
        }

        internal Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);

        internal string GetCustomRequestData(string requestStr) => CreateGetRequest(requestStr);
    }
}