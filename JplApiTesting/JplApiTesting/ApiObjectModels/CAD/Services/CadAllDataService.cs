namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadAllDataService : CadService
    {
        public CadAllDataService()
        {
            liveCurrent = callManager.GetAllCadData();
        
            Setup();
        }
    }
}