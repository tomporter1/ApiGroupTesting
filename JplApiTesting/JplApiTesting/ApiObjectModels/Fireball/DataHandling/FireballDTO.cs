using Newtonsoft.Json;
using static JplApiTesting.ApiObjectModels.Fireball.DataHandling.FireballModel;

namespace JplApiTesting.ApiObjectModels.Fireball.DataHandling
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