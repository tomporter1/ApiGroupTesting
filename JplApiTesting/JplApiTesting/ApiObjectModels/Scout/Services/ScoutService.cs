using JplApiTesting.ApiObjectModels.Scout.DataHandling;
using JplApiTesting.ApiObjectModels.Scout.HTTPManager;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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
            NEOdata = callManager.GetAllScoutData();
            dto.DeserializeLatestScout(NEOdata);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdata);
        }
    }
}