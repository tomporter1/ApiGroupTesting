using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.CAD.DataHandling
{
    public class CadLatestDTO
    {
        public CadLatestRoot LatestCAD { get; private set; }

        public void DeserializeLatestCAD(string LatestCADResponse)
        {
            LatestCAD = JsonConvert.DeserializeObject<CadLatestRoot>(LatestCADResponse);
        }
    }
}