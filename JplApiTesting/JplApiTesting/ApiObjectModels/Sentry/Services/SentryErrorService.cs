using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryErrorService : SentryService
	{
		public SentryErrorService(string request)
		{
			if (request == string.Empty)
				throw new ArgumentException("The request string is empty");

			liveCurrent = sentryCallManager.GetSentryObjectInfo(request);

			dto.DeserializeSentryError(liveCurrent);
			json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
		}
	}
}
