using System.Collections.Generic;
using RestSharp;

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

		internal string GetSentryIPInfo(string sentryIPValue, string exponent) => CreateGetRequest($"?all=1&ip-min={sentryIPValue}e-{exponent}");

		internal string GetSentryRemovedInfo(string removedValue) => CreateGetRequest($"?removed={removedValue}");

		internal Dictionary<string, string> GetContentTypeHeader() => TestTools.GetContentTypeHeader(response.Headers);
	}
}