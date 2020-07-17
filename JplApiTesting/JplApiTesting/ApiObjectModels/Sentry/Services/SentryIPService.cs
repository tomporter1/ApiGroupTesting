using System;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryIPService : SentryService
	{
		public SentryIPService(string sentryIPValue, string exponent)
		{
			int ip = -1;
			int exp = -1;

			try
			{
				ip = int.Parse(sentryIPValue);
				exp = int.Parse(exponent);

				if (ip < 1 || exp < 2 || exp > 10)
				{
					throw new ArgumentException("IP has to be greater than 1, Exponent cannot be greater than 10");
				}
			}
			catch
			{
				throw new ArgumentException("Invalid parameters must be int");
			}

			ResponseData = sentryCallManager.GetSentryIPInfo(sentryIPValue, exponent);
			dto.DeserializeSentryIP(ResponseData);
			SetupService();
		}
	}
}