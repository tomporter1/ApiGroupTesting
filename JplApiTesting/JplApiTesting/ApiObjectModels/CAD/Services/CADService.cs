using JplApiTesting.ApiObjectModels.CAD.DataHandling;
using JplApiTesting.ApiObjectModels.CAD.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    //https://ssd-api.jpl.nasa.gov/doc/cad.html
    public class CADService
    {
        public CadLatestCallManager callManager = new CadLatestCallManager();
        public CadLatestDTO dto = new CadLatestDTO();
        public string liveCurrent;
        public JObject json_current;

        public CADService()
        {
            liveCurrent = callManager.GetAllCadData();
            dto.DeserializeLatestCAD(liveCurrent);
            json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
        }

        public CADService(int limit)
        {
            if (limit < 0)
                throw new ArgumentException();

            liveCurrent = callManager.GetLimitData(limit);
            dto.DeserializeLatestCAD(liveCurrent);
            json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
        }
    }
}