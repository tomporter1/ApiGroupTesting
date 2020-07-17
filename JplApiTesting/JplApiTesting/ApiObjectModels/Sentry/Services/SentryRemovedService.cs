using System;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryRemovedService : SentryService
	{
		public SentryRemovedService(string removedValue)
		{
			List<string> checkInputMatch = new List<string> { "Y", "1", "true", "N", "0", "false" };
			if (checkInputMatch.Contains(removedValue))
			{
				ResponseData = sentryCallManager.GetSentryRemovedInfo(removedValue);
				dto.DeserializeSentryRemoved(ResponseData);
				SetupService();
			}
			else
			{
				throw new ArgumentException("Argument given in method is invalid must be: Y, 1, true or N, 0, false");
			}

			
		}
	}
}