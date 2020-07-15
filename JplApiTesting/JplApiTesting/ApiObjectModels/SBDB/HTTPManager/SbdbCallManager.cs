using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.SBDB.HTTPManager
{
    public class SbdbCallManager : BaseCallManager
    {
        public SbdbCallManager()
        {
            _client = new RestClient(SbdbConfigReader.BaseUrl);
        }

        internal string GetSpecificBodyData(string bodyName) => CreateGetRequest($"?sstr={bodyName}");
        internal Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);
    }
}