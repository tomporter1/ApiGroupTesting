using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
    public class SentryRemovedRoot
    {
        public string count { get; set; }
        public Signature signature { get; set; }
        public List<RemovedDatum> data { get; set; }
    }

    public class RemovedDatum
    {
        public string removed { get; set; }
        public string des { get; set; }
    }
}