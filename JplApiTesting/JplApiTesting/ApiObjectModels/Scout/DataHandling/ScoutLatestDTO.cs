using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Scout.DataHandling
{
    public class ScoutLatestDTO
    {
        public ScoutLatestRoot LatestScout { get; private set; }
        public ScoutLatestQueryRoot LatestScoutQuery { get; set; }

        public void DeserializeLatestScout(string LatestScoutResponse)
        {
            LatestScout = JsonConvert.DeserializeObject<ScoutLatestRoot>(LatestScoutResponse);
        }
        public void DeserializeLatestScoutQuery(string LatestScoutQueryResponse)
        {
            LatestScoutQuery = JsonConvert.DeserializeObject<ScoutLatestQueryRoot>(LatestScoutQueryResponse);
        }
    }
}