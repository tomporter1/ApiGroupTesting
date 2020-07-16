namespace JplApiTesting.ApiObjectModels.Sentry
{
	public class SentryConfigReader : ConfigReader
	{
		public static readonly string BaseUrl = configObj.Sentry.url;
	}
}