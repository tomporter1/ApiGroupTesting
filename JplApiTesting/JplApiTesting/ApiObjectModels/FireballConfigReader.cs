using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels
{
    public class FireballConfigReader
    {
        private static string jsonFilePath = AppDomain.CurrentDomain.BaseDirectory + @"ApiObjectModels\Config.json";

        private static ConfigRoot json =>
            JsonConvert.DeserializeObject<ConfigRoot>(File.ReadAllText(jsonFilePath));

        public static readonly string BaseUrl = json.Fireball.url;
    }
}