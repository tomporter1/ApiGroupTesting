using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutEphemerisDataService : ScoutService
    {
        public ScoutEphemerisDataService(string Name,string date)
        {
            NEOdata = callManager.GetScoutEphemerisData(Name, date);
            SetupForEphemeris();
        }   
    }
}
