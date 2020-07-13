using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader
    {
        private static ConfigRoot json => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFilePath));
        private static readonly string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"ApiObjectModels\Config.json";
    
        public static readonly string BaseUrl = json.CAD.url;
    }
}