using System.Collections.Generic;
using RestSharp;

namespace JplApiTesting.ApiObjectModels.Sentry.HTTPManager
{
	public class SentryCallManager
	{
		private readonly IRestClient _client;
		private IRestResponse _response;

		public SentryCallManager()
		{
			_client = new RestClient(SentryConfigReader.BaseUrl);
		}

		public string GetSentryInfo()
		{
			var request = new RestRequest();
			_response = _client.Execute(request, Method.GET);
			return _response.Content;
		}

		public string GetSentryObjectInfo(string sentryObjectName)
		{
			var request = new RestRequest($"?des={sentryObjectName.Replace(' ', '%')}");
			_response = _client.Execute(request, Method.GET);
			return _response.Content;
		}

		public string GetSentryIPInfo(int sentryIPValue, int exponent)
		{
			//"?all=1" refers to if the impact occurs, true or false (1 ,0)
			var request = new RestRequest($"?all=1&ip-min={sentryIPValue}e-{exponent}");
			_response = _client.Execute(request, Method.GET);
			return _response.Content;
		}

		internal Dictionary<string, string> GetContentTypeHeader()
		{
			Dictionary<string, string> HeadersDict = new Dictionary<string, string>();

			foreach (var item in _response.Headers)
			{
				string[] KeyPairs = item.ToString().Split('=');
				HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
			}
			return HeadersDict;
		}
	}
}