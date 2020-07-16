using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutNameQueryDataService : ScoutService
    {
        public ScoutNameQueryDataService(string objectName)
        {
            NEOdata = callManager.GetScoutDataForGivenName(objectName);
            SetupForGivenName();
        }
        
    }
}
