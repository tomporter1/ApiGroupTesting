using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.SBDB.DataHandiling
{
    public class SbdbDTO
    {
        public CometInfoRoot SbdbInfo { get; private set; }

        public void DeserializeLatestSBDB(in string LatestSBDBResponse)
        {
            SbdbInfo = JsonConvert.DeserializeObject<CometInfoRoot>(LatestSBDBResponse);
        }
    }
}