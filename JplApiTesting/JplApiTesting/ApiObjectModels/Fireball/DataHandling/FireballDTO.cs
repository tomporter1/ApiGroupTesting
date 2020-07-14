using Newtonsoft.Json;
using static JplApiTesting.DataHandling.FireballModel;

namespace JplApiTesting.DataHandling
{
    public class FireballDTO
    {
        private FireballRoot LatestReport { get; set; }

        public void DeserialiseLatest(in string fireballResponse)
        {
            LatestReport = JsonConvert.DeserializeObject<FireballRoot>(fireballResponse);
        }
    }
}