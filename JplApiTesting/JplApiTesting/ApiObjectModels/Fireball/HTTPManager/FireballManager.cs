using RestSharp;

namespace JplApiTesting.ApiObjectModels.Fireball.HTTPManager
{
    public class FireballManager : BaseCallManager
    {
        public FireballManager()
        {
            client = new RestClient(FireballConfigReader.BaseUrl);
        }

        // Would be good to test this
        public override string GetReport(in int numToShow = 0)
        {
            IRestRequest request
                = (numToShow <= 0) ? new RestRequest() : new RestRequest($"limit={numToShow}");
            response = client.Execute(request, Method.GET);
            return response.Content;
        }

        public string GetInvalidReport()
        {
            IRestRequest request = new RestRequest($"slime-cube=3");
            response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}