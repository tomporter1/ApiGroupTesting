using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels
{
    public class ConfigReader
    {
        protected static ConfigRoot _configObj => JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(_jsonFilePath));
        protected static readonly string _jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"ApiObjectModels\Config.json";
    }
}