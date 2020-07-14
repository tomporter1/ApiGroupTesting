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
        public string NEOdataforall;
        public string NEOdataforgiven;
        public JObject json_current;

        public ScoutService()
        {
            NEOdataforall = callManager.GetAllScoutData();
            dto.DeserializeLatestScout(NEOdataforall);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdataforall);
        }
        public ScoutService(string objectName) 
        {
            NEOdataforgiven = callManager.GetScoutDataForGivenName(objectName);
            dto.DeserializeLatestScoutQuery(NEOdataforgiven);
            json_current = JsonConvert.DeserializeObject<JObject>(NEOdataforgiven);
        }
    }
}