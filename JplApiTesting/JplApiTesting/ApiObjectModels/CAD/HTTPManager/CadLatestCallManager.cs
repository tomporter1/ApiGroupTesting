using RestSharp;
using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.HTTPManager
{
    public class CadLatestCallManager : BaseCallManager
    {
        public CadLatestCallManager()
        {
            _client = new RestClient(CADConfigReader.BaseUrl);
        }

        internal Dictionary<string, string> GetContentTypeHeader()
        {
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();

            foreach (var item in response.Headers)
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
        internal string GetCustomRequestData(string requestStr) => CreateGetRequest(requestStr);
        internal string GetDateFilteredData(string minDate, string maxDate) => CreateGetRequest($"?body=All&date-min={minDate}&date-max={maxDate}");
    }
}