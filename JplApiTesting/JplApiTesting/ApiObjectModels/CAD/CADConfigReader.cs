using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader
    {
        private static ConfigRoot Json => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(JsonFilePath));
        public static readonly string BaseUrl = Json.CAD.url;
        private static readonly string JsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\ApiObjectModels\Config.json";
    }
}