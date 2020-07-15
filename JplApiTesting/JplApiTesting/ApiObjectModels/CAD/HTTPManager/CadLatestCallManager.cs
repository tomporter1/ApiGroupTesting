using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.HTTPManager
{
    public class CadLatestCallManager : BaseCallManager
    {
        private readonly string _defaultBodyParam = $"{CADConfigReader.BodyParam}All";

        public CadLatestCallManager()
        {
            _client = new RestClient(CADConfigReader.BaseUrl);
        }

        internal Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);

        internal string GetAllCadData() => CreateGetRequest($"?{_defaultBodyParam}");
        internal string GetLimitData(int limit) => CreateGetRequest($"?{_defaultBodyParam}&{CADConfigReader.LimitParam}{limit}");
        internal string GetSpecificBodyData(string body) => CreateGetRequest($"?{CADConfigReader.BodyParam}{body}");
        internal string GetSpecificClassData(string classRequest) => CreateGetRequest($"?{_defaultBodyParam}&{CADConfigReader.ClassParam}{classRequest}");
        internal string GetCustomRequestData(string requestStr) => CreateGetRequest(requestStr);
        internal string GetDateFilteredData(string minDate, string maxDate) => CreateGetRequest($"?{_defaultBodyParam}&{CADConfigReader.MinDateParam}{minDate}&{CADConfigReader.MaxDateParam}{maxDate}");
    }
}