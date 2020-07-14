using JplApiTesting.ApiObjectModels.CAD.DataHandling;
using JplApiTesting.ApiObjectModels.CAD.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CADService
    {
        public CadLatestCallManager callManager = new CadLatestCallManager();
        public CadLatestDTO dto = new CadLatestDTO();
        public string liveCurrent;
        public JObject json_current;

        public CADService()
        {
            liveCurrent = callManager.GetAllCadData();
            dto.DeserializeLatestCAD(liveCurrent);
            json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
        }
    }
}