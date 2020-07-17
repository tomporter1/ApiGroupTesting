using System;

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
			return (value > 0) ? true : false;
		}

		public bool CompareDatesSpecifiedObject(string firstDate, string secondDate)
		{
			return (string.Equals(firstDate, secondDate) == false) ? false : true;
		}
	}
}