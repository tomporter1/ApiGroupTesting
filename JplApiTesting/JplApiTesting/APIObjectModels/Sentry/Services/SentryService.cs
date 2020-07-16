using System;
using JplApiTesting.ApiObjectModels.Sentry.DataHandling;
using JplApiTesting.ApiObjectModels.Sentry.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public abstract class SentryService
	{
		public SentryCallManager sentryCallManager = new SentryCallManager();
		public SentryDTO dto = new SentryDTO();
		public string liveCurrent;
		public JObject json_current;

		public void SetupService()
		{
			json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
		}

		
	}
}