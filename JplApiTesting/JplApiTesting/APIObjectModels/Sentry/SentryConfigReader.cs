namespace JplApiTesting.ApiObjectModels.Sentry
{
    public class SentryConfigReader : ConfigReader
    {
        public static readonly string BaseUrl = _configObj.Sentry.url;
    }
}