namespace JplApiTesting.ApiObjectModels.CAD.Services
{
	public class CadAllDataService : CADService
	{
		public CadAllDataService()
		{
			liveCurrent = callManager.GetAllCadData();

			Setup();
		}
	}
}