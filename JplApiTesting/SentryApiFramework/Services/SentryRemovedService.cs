namespace JplApiTesting.ApiObjectModels.Sentry.Services
{
    public class SentryRemovedService : SentryService
    {
        public SentryRemovedService(string removedValue)
        {
            ResponseData = sentryCallManager.GetSentryRemovedInfo(removedValue);
            dto.DeserializeSentryRemoved(ResponseData);
            SetupService();
        }
    }
}