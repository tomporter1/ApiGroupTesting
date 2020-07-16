using JplApiTesting.ApiObjectModels.CAD.DataHandling;
using JplApiTesting.ApiObjectModels.CAD.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    //https://ssd-api.jpl.nasa.gov/doc/cad.html
    public abstract class CadService : ServiceBase
    {
        public CadLatestCallManager callManager = new CadLatestCallManager();
        public CadLatestDTO dto = new CadLatestDTO();

        protected void Setup()
        {
            dto.DeserializeLatestCAD(ResponseData);
            JObjectResponse = JsonConvert.DeserializeObject<JObject>(ResponseData);
        }

        public bool AllDataItemsHaveSameNumOfFields(int numOfFields)
        {
            foreach (List<string> dataItem in dto.LatestCAD.data)
            {
                if (dataItem.Count != numOfFields)
                    return false;
            }
            return true;
        }
    }
}