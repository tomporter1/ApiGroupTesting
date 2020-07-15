using Newtonsoft.Json;
using System;

namespace JplApiTesting.ApiObjectModels.SBDB.DataHandiling
{
    public class SbdbDTO
    {
        public CometInfoRoot SbdbInfo { get; private set; }
        public SbdbErrorRoot SbdbError { get; private set; }

        public void DeserializeLatestSBDB(in string LatestSBDBResponse)
        {
            SbdbInfo = JsonConvert.DeserializeObject<CometInfoRoot>(LatestSBDBResponse);
        }

        internal void DeserializeSBDBError(string LatestSBDBResponse)
        {
            SbdbError = JsonConvert.DeserializeObject<SbdbErrorRoot>(LatestSBDBResponse);
        }
    }
}