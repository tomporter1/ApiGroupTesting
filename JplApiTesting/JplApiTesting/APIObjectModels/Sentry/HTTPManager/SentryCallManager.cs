using RestSharp;
using System;
using System.Collections.Generic;

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
			var response = _client.Execute(request,Method.GET);
			return response.Content;
		}

		public string GetSentryObjectInfo(string sentryObjectName)
		{			
			var request = new RestRequest($"?des={sentryObjectName.Replace(' ', '%')}");
			var response = _client.Execute(request, Method.GET);
			return response.Content;
		}
	}
}
