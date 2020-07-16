using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryRemovedService : SentryService
	{
		private int state = 0;
		public SentryRemovedService(bool removedValue)
		{
			if (removedValue == true)
			{
				state = 1;
			}
			else
			{
				state = 0;
			}
			liveCurrent = sentryCallManager.GetSentryRemovedInfo(state);
			dto.DeserializeSentryRemoved(liveCurrent);
			SetupService();
		}
	}
}
