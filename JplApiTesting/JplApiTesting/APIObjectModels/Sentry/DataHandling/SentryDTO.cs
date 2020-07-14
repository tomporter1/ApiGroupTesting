using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
	public class SentryDTO
	{
		public SentryRoot LatestSentry { get; private set; }

		public SentrySpecifiedRoot specifiedSentry { get; private set; }

		public void DeserializeLatestSentry(string LatestSentryResponse)
		{
			LatestSentry = JsonConvert.DeserializeObject<SentryRoot>(LatestSentryResponse);
		}

		public void DeserializeSpecifiedSentry(string specifiedSentryResponse)
		{
			specifiedSentry = JsonConvert.DeserializeObject<SentrySpecifiedRoot>(specifiedSentryResponse);
		}

	}
}
