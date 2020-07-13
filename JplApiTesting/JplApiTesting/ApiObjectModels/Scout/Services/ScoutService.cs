using JplApiTesting.ApiObjectModels.Scout.DataHandling;
using JplApiTesting.ApiObjectModels.Scout.HTTPManager;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutService
    {
        public ScoutLatestCallManager callManager = new ScoutLatestCallManager();
        public ScoutLatestDTO dto = new ScoutLatestDTO();
        public string liveCurrent;
        public JObject json_current;
    }
}