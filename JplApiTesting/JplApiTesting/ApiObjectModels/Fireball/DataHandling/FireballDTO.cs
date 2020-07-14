using Newtonsoft.Json;
using static JplApiTesting.DataHandling.FireballModel;

namespace JplApiTesting.DataHandling
{
    public class FireballDTO
    {
        public FireballRoot LatestReport { get; set; }

        public void DeserialiseLatest(in string fireballResponse)
        {
            LatestReport = JsonConvert.DeserializeObject<FireballRoot>(fireballResponse);
        }
    }
}