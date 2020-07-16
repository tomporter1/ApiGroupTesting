using System;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryIPService : SentryService
	{
		public SentryIPService(string sentryIPValue, string exponent)
		{
			int ip = int.Parse(sentryIPValue);
			int exp = int.Parse(exponent);

			if (ip < 1 || exp < 2 || exp > 10)
			{
				throw new ArgumentException("Invalid parameters, IP has to be greater than 1, Exponent cannot be greater than 10");
			}
			ResponseData = sentryCallManager.GetSentryIPInfo(sentryIPValue, exponent);
			dto.DeserializeSentryIP(ResponseData);
			SetupService();
		}
	}
}