using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Scout;

namespace JplApiTesting.ApiObjectModels
{
    public class ScoutConfigReader
    {
        private static ConfigRoot json => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFilePath));
        private static readonly string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory +  @"ApiObjectModels\Config.json";
        public static readonly string ScoutUrl = json.Scout.url;
    }
}