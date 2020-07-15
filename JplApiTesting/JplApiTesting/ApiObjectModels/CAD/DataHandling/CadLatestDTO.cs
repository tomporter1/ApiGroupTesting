using Newtonsoft.Json;

namespace JplApiTesting.ApiObjectModels.CAD.DataHandling
{
	public class CadLatestDTO
	{
		public CadLatestRoot LatestCAD { get; private set; }

		public void DeserializeLatestCAD(in string LatestCADResponse)
		{
			LatestCAD = JsonConvert.DeserializeObject<CadLatestRoot>(LatestCADResponse);
		}
	}
}