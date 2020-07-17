using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels
{
    public class ConfigRoot
    {
        public CadInfo CAD { get; set; }
        public Info Fireball { get; set; }
        public ScoutInfo Scout { get; set; }
        public Info Sentry { get; set; }
        public Info SBDB { get; set; }
    }

    public class Info
    {
        public string url { get; set; }
    }

    public class ScoutInfo
    {
        public string url { get; set; }
        public ScoutParameters parameters { get; set; }
    }

    public class ScoutParameters
    {
        public string tdes { get; set; }
        public string date { get; set; }
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

    public class FireballInfo
    {
        public string url { get; set; }
        public FireballParameters parameters { get; set; }
    }

    public class FireballParameters
    {
        public string minDate { get; set; }
        public string maxDate { get; set; }
        public string minEnergy { get; set; }
        public string maxEnergy { get; set; }
        public string minEstimatedImpact { get; set; }
        public string maxEstimatedImpact { get; set; }
        public string minVelocity { get; set; }
        public string maxVelocity { get; set; }
        public string locationRequired { get; set; }
        public string altitudeRequired { get; set; }
        public string velocityComponentsRequired { get; set; }
        public string velocityComponents { get; set; }
        public string sort { get; set; }
        public string limit { get; set; }
    }
}