namespace JplApiTesting.ApiObjectModels.Scout.Services
{
    public class ScoutNameQueryDataService : ScoutService
    {
        public ScoutNameQueryDataService(string name)
        {
            ResponseData = callManager.GetScoutDataForGivenName(name);
            SetupForGivenName();
        }
    }
}