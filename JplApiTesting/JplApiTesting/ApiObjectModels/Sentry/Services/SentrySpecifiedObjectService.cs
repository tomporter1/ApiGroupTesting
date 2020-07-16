using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentrySpecifiedObjectService : SentryService
	{
		public SentrySpecifiedObjectService(string sentryObjectName)
		{
			liveCurrent = sentryCallManager.GetSentryObjectInfo(sentryObjectName);
			dto.DeserializeSpecifiedSentry(liveCurrent);
			SetupService();
		}
		public bool CheckMassIsOverZeroSpecifiedObject(string mass)
		{
			mass.Replace("e+10", "");
			double value = Double.Parse(mass);
			if (value > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool CompareDatesSpecifiedObject(string firstDate, string secondDate)
		{
			if (string.Equals(firstDate, secondDate) == false)
			{
				return false;
			}
			else
			{
				return true;
			};
		}
	}
}
