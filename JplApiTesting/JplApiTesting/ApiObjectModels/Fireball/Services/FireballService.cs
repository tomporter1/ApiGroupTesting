using JplApiTesting.DataHandling;
using JplApiTesting.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JplApiTesting.Services
{
    public class FireballService
    {
        public FireballManager fireballManager = new FireballManager();
        public FireballDTO fireballDTO = new FireballDTO();

        public string fireballReport;
        public JObject json_report;

        public FireballService(in int desiredLimit = 0)
        {
            fireballReport = fireballManager.GetReport(desiredLimit);
            fireballDTO.DeserialiseLatest(fireballReport);
            json_report = JsonConvert.DeserializeObject<JObject>(fireballReport);
        }

        public List<string> GetFields()
        {
            return fireballDTO.LatestReport.fields;
        }

        public int GetCount()
        {
            return json_report.Value<int>("count");
        }
    }
}