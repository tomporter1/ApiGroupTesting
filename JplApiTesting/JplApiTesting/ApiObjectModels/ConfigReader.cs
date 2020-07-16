using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels
{
    public class ConfigReader
    {
        protected static ConfigRoot configObj => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFilePath));
        protected static readonly string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"ApiObjectModels\Config.json";
    }
}