using JplApiTesting.ApiObjectModels.Scout.DataHandling;
using JplApiTesting.ApiObjectModels.Scout.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutService
    {
        public ScoutLatestCallManager callManager = new ScoutLatestCallManager();
        public ScoutLatestDTO dto = new ScoutLatestDTO();
        public string NEOdata;
        public JObject json_current;

        public ScoutService()
        {
        }

        public void SetupForAll()
        {
            dto.DeserializeLatestScout(NEOdata);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdata);
        }

        public void SetupForGivenName()
        {
            dto.DeserializeLatestScoutQueryName(NEOdata);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdata);
        }

        public void SetupForEphemeris()
        {
            dto.DeserializeLatestScoutEphemeris(NEOdata);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdata);
        }
    }
}