using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.SBDB.DataHandiling
{
    public class CometInfoRoot
    {
        [JsonProperty("object")]
        public Object _object { get; set; }

        public Signature signature { get; set; }
        public Orbit orbit { get; set; }
    }

    public class Object
    {
        public bool neo { get; set; }
        public Orbit_Class orbit_class { get; set; }
        public bool pha { get; set; }
        public string spkid { get; set; }
        public string kind { get; set; }
        public string orbit_id { get; set; }
        public string fullname { get; set; }
        public string des { get; set; }
        public string prefix { get; set; }
    }

    public class Orbit_Class
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class Orbit
    {
        public string source { get; set; }
        public string cov_epoch { get; set; }
        public string moid_jup { get; set; }
        public string t_jup { get; set; }
        public object condition_code { get; set; }
        public object not_valid_before { get; set; }
        public string rms { get; set; }
        public object[] model_pars { get; set; }
        public string orbit_id { get; set; }
        public string producer { get; set; }
        public string first_obs { get; set; }
        public string soln_date { get; set; }
        public object two_body { get; set; }
        public string epoch { get; set; }
        public Element[] elements { get; set; }
        public string equinox { get; set; }
        public string data_arc { get; set; }
        public object not_valid_after { get; set; }
        public object n_del_obs_used { get; set; }
        public string sb_used { get; set; }
        public string n_obs_used { get; set; }
        public object comment { get; set; }
        public string pe_used { get; set; }
        public string last_obs { get; set; }
        public string moid { get; set; }
        public object n_dop_obs_used { get; set; }
    }

    public class Element
    {
        public string value { get; set; }
        public string sigma { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string label { get; set; }
        public string units { get; set; }
    }
}