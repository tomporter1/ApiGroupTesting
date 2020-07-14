﻿using JplApiTesting.ApiObjectModels.Sentry.DataHandling;
using JplApiTesting.ApiObjectModels.Sentry.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryService
	{
		public SentryCallManager sentryCallManager = new SentryCallManager();
		public SentryDTO dto = new SentryDTO();
		public string liveCurrent;
		public JObject json_current;

		public SentryService()
		{
			liveCurrent = sentryCallManager.GetSentryInfo();
			dto.DeserializeLatestSentry(liveCurrent);
			json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
		}

		public SentryService(string sentryObjectName)
		{
			liveCurrent = sentryCallManager.GetSentryObjectInfo(sentryObjectName);
			dto.DeserializeLatestSentry(liveCurrent);
			json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
		}
	}
}
