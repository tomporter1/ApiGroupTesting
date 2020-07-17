using JplApiTesting.ApiObjectModels.Scout.DataHandling;
using JplApiTesting.ApiObjectModels.Scout.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public abstract class ScoutService : ServiceBase
    {
        public ScoutLatestCallManager callManager = new ScoutLatestCallManager();
        public ScoutLatestDTO dto = new ScoutLatestDTO();
        public ScoutService()
        {
        }
        public void SetupForAll()
        {
            dto.DeserializeLatestScout(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
        public void SetupForGivenName()
        {
            dto.DeserializeLatestScoutQueryName(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
        public void SetupForEphemeris()
        {
            dto.DeserializeLatestScoutEphemeris(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
    }
}