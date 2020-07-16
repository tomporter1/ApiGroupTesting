using System;
using JplApiTesting.ApiObjectModels.Sentry.DataHandling;
using JplApiTesting.ApiObjectModels.Sentry.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public abstract class SentryService : ServiceBase
	{
		public SentryCallManager sentryCallManager = new SentryCallManager();
		public SentryDTO dto = new SentryDTO();

		public void SetupService()
		{
			JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
		}

		public DateTime CovertAPIDate(string dateFromApi)
		{
			string[] dateparts = dateFromApi.Split('-');

			int year = int.Parse(dateparts[0]);
			string month = dateparts[1];
			string dayAsDouble = dateparts[2];

			int day = (int)Math.Floor(double.Parse(dayAsDouble));

			switch (month)
			{
				case "Jan":
					month = "1";
					break;

				case "Feb":
					month = "2";
					break;

				case "Mar":
					month = "3";
					break;

				case "Apr":
					month = "4";
					break;

				case "May":
					month = "5";
					break;

				case "Jun":
					month = "6";
					break;

				case "Jul":
					month = "7";
					break;

				case "Aug":
					month = "8";
					break;

				case "Sep":
					month = "9";
					break;

				case "Oct":
					month = "10";
					break;

				case "Nov":
					month = "11";
					break;

				case "Dec":
					month = "12";
					break;

				default:
					month = "";
					break;
			}
			return new DateTime(year, int.Parse(month), day);
		}

		public string CompareDateToCurrent(DateTime apiDate)
		{
			string resultFromComparison = "";
			DateTime systemDateTime = DateTime.Now;

			var outputFromComparison = DateTime.Compare(apiDate, systemDateTime);

			if (outputFromComparison == -1)
			{
				resultFromComparison = "API Date is before current.";
			}
			else if (outputFromComparison == 0)
			{
				resultFromComparison = "API Date is equal to current.";
			}
			else if (outputFromComparison == 1)
			{
				resultFromComparison = "API Date is after current.";
			}
			return resultFromComparison;
		}
	}
}