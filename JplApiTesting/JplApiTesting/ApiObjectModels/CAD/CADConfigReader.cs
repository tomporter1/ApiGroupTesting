using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader
    {
        private static ConfigRoot _configObj => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(_jsonFilePath));
        private static readonly string _jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"ApiObjectModels\Config.json";
    
        public static readonly string BaseUrl = _configObj.CAD.url;
    }
}