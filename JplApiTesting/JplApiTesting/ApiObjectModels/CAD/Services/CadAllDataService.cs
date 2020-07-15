namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadAllDataService : CadService
    {
        public CadAllDataService()
        {
            ResponceData = callManager.GetAllCadData();

            Setup();
        }
    }
}