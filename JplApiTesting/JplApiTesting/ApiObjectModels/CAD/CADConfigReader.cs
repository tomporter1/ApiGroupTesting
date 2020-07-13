using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader
    {
        private static ConfigRoot json => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFilePath));
        public static readonly string BaseUrl = json.CAD.url;
        private static readonly string jsonFilePath = @"..\ApiObjectModels\Config.json";
    }
}