using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutEphemerisDataService : ScoutService
    {
        public ScoutEphemerisDataService(string name,string date)
        {
            ResponseData = callManager.GetScoutEphemerisData(name, date);
            SetupForEphemeris();
        }   
    }
}
