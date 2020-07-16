using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
	public class SentryDTO
	{
		public SentryRoot LatestSentry { get; private set; }

		public SentrySpecifiedRoot SpecifiedSentry { get; private set; }

		public SentryErrorRoot ErrorSentry { get; private set; }

		public SentryIPRoot SentryIP { get; private set; }

		public SentryRemovedRoot SentryRemoved { get; private set; }

		public void DeserializeLatestSentry(string LatestSentryResponse)
		{
			LatestSentry = JsonConvert.DeserializeObject<SentryRoot>(LatestSentryResponse);
		}

		public void DeserializeSpecifiedSentry(string specifiedSentryResponse)
		{
			SpecifiedSentry = JsonConvert.DeserializeObject<SentrySpecifiedRoot>(specifiedSentryResponse);
		}

		public void DeserializeSentryIP(string SentryIPResponse)
		{
			SentryIP = JsonConvert.DeserializeObject<SentryIPRoot>(SentryIPResponse);
		}
		public void DeserializeSentryRemoved(string sentryRemovedResponse)
		{
			SentryRemoved = JsonConvert.DeserializeObject<SentryRemovedRoot>(sentryRemovedResponse);
		}

		public void DeserializeSentryError(string sentryResponse)
		{
			ErrorSentry = JsonConvert.DeserializeObject<SentryErrorRoot>(sentryResponse);
		}
	}
}