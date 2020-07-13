using JplApiTesting.DataHandling;
using JplApiTesting.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JplApiTesting.Services
{
    public class FireballService
    {
        public FireballManager fireballManager = new FireballManager();
        public FireballDTO fireballDTO = new FireballDTO();

        public string fireballReport;
        public JObject json_report;

        public FireballService()
        {
            fireballReport = fireballManager.GetReport();
            fireballDTO.DeserialiseLatest(fireballReport);
            json_report = JsonConvert.DeserializeObject<JObject>(fireballReport);
        }

        public int GetCount()
        {
            return json_report.Value<int>("count");
        }
    }
}