using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
    public class SentryIPRoot
    {
        public int count { get; set; }
        public Signature signature { get; set; }
        public List<SentryIPDatum> data { get; set; }
    }

    public class SentryIPDatum
    {
        public string width { get; set; }
        public string energy { get; set; }
        public string ts { get; set; }
        public string ip { get; set; }
        public string stretch { get; set; }
        public string date { get; set; }
        public string dist { get; set; }
        public string sigma_lov { get; set; }
        public string sigma_imp { get; set; }
        public string fullname { get; set; }
        public string id { get; set; }
        public string method { get; set; }
        public string des { get; set; }
        public string ps { get; set; }
    }
}