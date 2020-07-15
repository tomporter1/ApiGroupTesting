using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutAllDataService : ScoutService
    {
        public ScoutAllDataService()
        {
            NEOdata = callManager.GetAllScoutData();
            SetupForAll();
        }
  
    }
}
