namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutAllDataService : ScoutService
    {
        public ScoutAllDataService()
        {
            ResponseData = callManager.AllScoutData;
            SetupForAll();
        }
    }
}