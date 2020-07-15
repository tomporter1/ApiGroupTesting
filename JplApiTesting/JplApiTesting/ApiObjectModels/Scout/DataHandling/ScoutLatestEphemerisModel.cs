using Newtonsoft.Json;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Scout.DataHandling
{
    
    public class EphemerisModelRoot
    {
        public string count { get; set; }
        [JsonProperty("object")]
        public Object _object { get; set; }
        public Signature signature { get; set; }
        public List<Eph> eph { get; set; }
        public List<string> datafields { get; set; }
        [JsonProperty("orbit-count")]
        public int orbitcount { get; set; }
    }

    public class Object
    {
        public string neo1kmScore { get; set; }
        public string lastRun { get; set; }
        public string uncP1 { get; set; }
        public string dec { get; set; }
        public string neoScore { get; set; }
        public string rating { get; set; }
        public string rate { get; set; }
        public string unc { get; set; }
        public string phaScore { get; set; }
        public string ra { get; set; }
        public string elong { get; set; }
        public string nObs { get; set; }
        public string arc { get; set; }
        public string tEphem { get; set; }
        public string objectName { get; set; }
        public string tisserandScore { get; set; }
        public object caDist { get; set; }
        public object vInf { get; set; }
        public string H { get; set; }
        public string rmsN { get; set; }
        public string ieoScore { get; set; }
        public string geocentricScore { get; set; }
        public string moid { get; set; }
        public string Vmag { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class Eph
    {
        public string sigmapos { get; set; }
        public Limits limits { get; set; }
        public string time { get; set; }
        public object[][] data { get; set; }
        public Median median { get; set; }
        public SigmaLimits sigmalimits { get; set; }
    }

    public class Limits
    {
        public Dec dec { get; set; }
        public Rate rate { get; set; }
        public Pa pa { get; set; }
        public Moon moon { get; set; }
        public Dra dra { get; set; }
        public Ra ra { get; set; }
        public Ddec ddec { get; set; }
        public Vmag vmag { get; set; }
        public Elong elong { get; set; }
    }

    public class Dec
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Rate
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Pa
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Moon
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Dra
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Ra
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Ddec
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Vmag
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Elong
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Median
    {
        public string dec { get; set; }
        public string rate { get; set; }
        public string pa { get; set; }
        public string moon { get; set; }
        public string dra { get; set; }
        public string ra { get; set; }
        public string ddec { get; set; }
        public string vmag { get; set; }
        public string elong { get; set; }
    }

    public class SigmaLimits
    {
        public Ra1 ra { get; set; }
        public Vmag1 vmag { get; set; }
        public Dec1 dec { get; set; }
    }

    public class Ra1
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Vmag1
    {
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Dec1
    {
        public string min { get; set; }
        public string max { get; set; }
    }

}
