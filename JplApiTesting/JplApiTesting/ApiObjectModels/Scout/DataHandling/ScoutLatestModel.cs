namespace JplApiTesting.ApiObjectModels.Scout.DataHandling
{
    public class ScoutLatestRoot
    {
        public string count { get; set; }
        public Signature signature { get; set; }
        public Datum[] data { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }

    public class Datum
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
        public string caDist { get; set; }
        public string vInf { get; set; }
        public string H { get; set; }
        public string rmsN { get; set; }
        public string ieoScore { get; set; }
        public string geocentricScore { get; set; }
        public string moid { get; set; }
        public string Vmag { get; set; }
    }
}