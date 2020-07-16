using System;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
    public class SentryErrorService : SentryService
	{
		public SentryErrorService(string request)
		{
			if (request == string.Empty)
				throw new ArgumentException("The request string is empty");

			ResponseData = sentryCallManager.GetSentryObjectInfo(request);

			dto.DeserializeSentryError(ResponseData);
			SetupService();
		}
	}
}
