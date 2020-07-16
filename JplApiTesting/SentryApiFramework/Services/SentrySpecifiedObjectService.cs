using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentrySpecifiedObjectService : SentryService
	{
		public SentrySpecifiedObjectService(string sentryObjectName)
		{
			ResponseData = sentryCallManager.GetSentryObjectInfo(sentryObjectName);
			dto.DeserializeSpecifiedSentry(ResponseData);
			SetupService();
		}
		public bool CheckMassIsOverZeroSpecifiedObject(string mass)
		{
			mass.Replace("e+10", "");
			double value = Double.Parse(mass);
			return (value > 0) ?  true : false;
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
