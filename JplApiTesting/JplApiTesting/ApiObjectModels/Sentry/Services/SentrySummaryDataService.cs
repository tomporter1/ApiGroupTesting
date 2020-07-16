using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentrySummaryDataService : SentryService
	{
		public SentrySummaryDataService()
		{		
			liveCurrent = sentryCallManager.GetSentryInfo();
			dto.DeserializeLatestSentry(liveCurrent);
			SetupService();
		}
	}
}
