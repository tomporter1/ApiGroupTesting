using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Sentry.HTTPManager
{
    public class SentryCallManager : BaseCallManager
    {
        public SentryCallManager()
        {
            client = new RestClient(SentryConfigReader.BaseUrl);
        }

        internal string GetSentryInfo() => CreateGetRequest("");

        internal string GetSentryObjectInfo(string sentryObjectName) => CreateGetRequest($"?des={sentryObjectName.Replace(' ', '%')}");

        internal string GetSentryIPInfo(double sentryIPValue, int exponent) => CreateGetRequest($"?all=1&ip-min={sentryIPValue}e-{exponent}");

        internal string GetSentryRemovedInfo(string removedValue) => CreateGetRequest($"?removed={removedValue}");

        public Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);
    }
}