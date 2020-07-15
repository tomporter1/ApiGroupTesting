using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels
{
    public class ConfigRoot    
    {
        public CadInfo CAD { get; set; }
        public Info Fireball { get; set; }
        public Info Scout { get; set; }
        public Info Sentry { get; set; }
    }
     public class Info
    {
        public string url { get; set; }
    }

    public class CadInfo
    {
        public string url { get; set; }
        public CadParameters parameters { get; set; }
    }

    public class CadParameters
    {
        public string body { get; set; }
        public string limit { get; set; }
        public string minDate { get; set; }
        public string maxDate { get; set; }

        [JsonProperty("class")]
        public string _class { get; set; }
    }
}