using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentryIPService : SentryService
	{
		public SentryIPService(double sentryIPValue, int exponent)
		{
			if (sentryIPValue < 1 || exponent < 1 || exponent > 10)
			{
				throw new ArgumentException("Error: IP value and Exponent must be greater than 0");
			}
			ResponseData = sentryCallManager.GetSentryIPInfo(sentryIPValue, exponent);
			dto.DeserializeSentryIP(ResponseData);
			SetupService();
		}
	}
}
