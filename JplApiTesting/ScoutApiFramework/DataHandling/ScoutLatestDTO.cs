using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.Scout.DataHandling
{
    public class ScoutLatestDTO
    {
        public ScoutLatestRoot LatestScout { get; private set; }
        public ScoutLatestNameQueryRoot LatestScoutQueryName { get; set; }
        public EphemerisModelRoot LatestScoutEphemeris { get; set; }


        public void DeserializeLatestScout(string LatestScoutResponse)
        {
            LatestScout = JsonConvert.DeserializeObject<ScoutLatestRoot>(LatestScoutResponse);
        }

        public void DeserializeLatestScoutQueryName(string LatestScoutQueryResponse)
        {
            LatestScoutQueryName = JsonConvert.DeserializeObject<ScoutLatestNameQueryRoot>
                (LatestScoutQueryResponse);
        }

        public void DeserializeLatestScoutEphemeris(string LatestScoutQueryResponse) 
        {
            LatestScoutEphemeris = JsonConvert.DeserializeObject<EphemerisModelRoot>
                (LatestScoutQueryResponse);
        }
    }
}