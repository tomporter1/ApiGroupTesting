using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.Scout.DataHandling
{
    public class ScoutLatestDTO
    {
        public ScoutLatestRoot LatestScout { get; private set; }

        public void DeserializeLatestScout(string LatestScoutResponse)
        {
            LatestScout = JsonConvert.DeserializeObject<ScoutLatestRoot>(LatestScoutResponse);
        }
    }
}