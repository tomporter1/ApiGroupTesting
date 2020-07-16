using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels
{
    public abstract class BaseCallManager
    {
        protected IRestClient client;
        protected IRestResponse response;

        public virtual string GetReport(in int numToShow = 0)
        {
            return "";
        }

        protected virtual string CreateGetRequest(string RequestString)
        {
            RestRequest request = new RestRequest(RequestString);
            response = client.Execute(request, Method.GET);
            return response.Content;
        }

        internal string MakeRequest(Dictionary<RequestParametersTypes, RequestParameterInfo> paramDict)
        {
            if(paramDict.Count == 0)
                return CreateGetRequest("");

            string requestStr = "?";
            int x = 0;
            foreach (KeyValuePair<RequestParametersTypes, RequestParameterInfo> pair in paramDict)
            {
                requestStr += $"{pair.Value.Label}{pair.Value.Data}&";
                if (x < paramDict.Count)
                    requestStr += "&";
                x++;
            }
            return CreateGetRequest(requestStr);
        }
    }
}