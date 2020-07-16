using JplApiTesting.ApiObjectModels.SBDB.DataHandiling;
using JplApiTesting.ApiObjectModels.SBDB.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.ApiObjectModels.SBDB.Services
{
    public class SbdbService : ServiceBase
    {
        public SbdbCallManager callManager = new SbdbCallManager();
        public SbdbDTO DTO = new SbdbDTO();

        protected void SetUp()
        {
            DTO.DeserializeLatestSBDB(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }
    }
}