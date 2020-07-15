using JplApiTesting.ApiObjectModels.Fireball;
using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;
using RestSharp;

namespace JplApiTesting.Tests.Fireball.InvalidQuerying
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApiGivenInvalidQueryingShould
    {
        protected FireballService _fireballService = null;
        protected const int NumToQuery = 20;

        [SetUp]
        [Author("K McEvaddy")]
        public virtual void Setup()
        {
            _fireballService = new FireballService(NumToQuery);
        }

        [TestCase("?slime-cube=3")]
        [TestCase("?eightynine=89")]
        [TestCase("?happy=birthday")]
        [Author("K McEvaddy")]
        public void ContainParameter_MoreInfo_Containing_LinkToDocumentation(in string parameters)
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest(parameters);
            IRestResponse response = client.Execute(request, Method.GET);
            string content = response.Content;
            string[] contentSplitByColons = content.Split(':');
            string moreInfo = contentSplitByColons[1] + ':' + contentSplitByColons[2];
            // Assert
            Assert.That(moreInfo, Does.Contain(@"https://ssd-api.jpl.nasa.gov/doc/fireball.html"));
        }

        [TestCase("?slime-cube=3")]
        [TestCase("?eightynine=89")]
        [TestCase("?happy=birthday")]
        [Author("K McEvaddy")] 
        public void ContainParameter_Message_Containing_UnrecognisedParamError(in string parameters) 
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest(parameters);
            IRestResponse response = client.Execute(request, Method.GET);
            string content = response.Content;
            string[] contentSplitByColons = content.Split(':');
            string message = contentSplitByColons[contentSplitByColons.Length - 2];
            // Assert
            Assert.That(message,Does.Contain("one or more query parameter was not recognized"));
        }

        [TestCase("?slime-cube=3")]
        [TestCase("?eightynine=89")]
        [TestCase("?happy=birthday")]
        [Author("K McEvaddy")] 
        public void ContainParameter_Code_Containing_InvalidRequestCode(in string parameters) 
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest(parameters);
            IRestResponse response = client.Execute(request, Method.GET);
            string content = response.Content;
            string[] contentSplitByColons = content.Split(':');
            string code = contentSplitByColons[contentSplitByColons.Length - 1];
            // Assert
            Assert.That(code,Does.Contain("400"));
        }
    }
}