namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
	public class SentrySummaryDataService : SentryService
	{
		public SentrySummaryDataService()
		{
			ResponseData = sentryCallManager.GetSentryInfo();
			dto.DeserializeLatestSentry(ResponseData);
			SetupService();
		}
	}
}