using System;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryErrorService : SentryService
	{
		public SentryErrorService(string SentryAPIUnderTest, string request)
		{
			if (request == string.Empty)
				throw new ArgumentException("The request string is empty");

			if (SentryAPIUnderTest == "SentrySpecifiedObject")
			{
				ResponseData = sentryCallManager.GetSentryObjectInfo(sentryObjectName: request);
			}
			else if (SentryAPIUnderTest == "SentryRemoved")
			{
				ResponseData = sentryCallManager.GetSentryRemovedInfo(removedValue: request);
			}
			

			dto.DeserializeSentryError(ResponseData);
			SetupService();
		}

		public SentryErrorService(string SentryAPIUnderTest, string invalidIPValue, string invalidExponent)
		{
			if (SentryAPIUnderTest == "SentryIP")
			{
				ResponseData = sentryCallManager.GetSentryIPInfo(sentryIPValue: invalidIPValue, exponent: invalidExponent);
			}
			dto.DeserializeSentryError(ResponseData);
			SetupService();
		}
	}
}