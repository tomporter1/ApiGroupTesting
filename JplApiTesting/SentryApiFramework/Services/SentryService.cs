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
    }
}