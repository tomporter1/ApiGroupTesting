using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryRemovedService : SentryService
	{
		public SentryRemovedService(string removedValue)
		{
			ResponseData = sentryCallManager.GetSentryRemovedInfo(removedValue);
			dto.DeserializeSentryRemoved(ResponseData);
			SetupService();

		}
	}
}
