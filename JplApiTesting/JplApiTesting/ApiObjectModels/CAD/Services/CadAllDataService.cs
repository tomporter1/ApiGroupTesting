namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadAllDataService : CadService
    {
        public CadAllDataService()
        {
            ResponseData = callManager.GetAllCadData();

            Setup();
        }
    }
}