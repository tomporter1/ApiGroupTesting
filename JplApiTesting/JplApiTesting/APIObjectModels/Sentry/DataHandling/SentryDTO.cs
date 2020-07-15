using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
    public class SentryDTO
    {
        public SentryRoot LatestSentry { get; private set; }

        public void DeserializeLatestSentry(string LatestSentryResponse)
        {
            LatestSentry = JsonConvert.DeserializeObject<SentryRoot>(LatestSentryResponse);
        }
    }
}