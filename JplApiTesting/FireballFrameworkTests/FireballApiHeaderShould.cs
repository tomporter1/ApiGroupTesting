using JplApiTesting.ApiObjectModels.Fireball;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;

namespace JplApiTesting.Tests.Fireball
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApiHeaderShould
    {
        [Test]
        public void ContainKey_TransferEncoding_Equalling_Chunked()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string transferEncoding = HeadersDict["Transfer-Encoding"];
            // Assert
            Assert.That(transferEncoding, Is.EqualTo("chunked"));
        }

        [Test]
        public void ContainKey_Connection_Equalling_KeepAlive()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string connection = HeadersDict["Connection"];
            // Assert
            Assert.That(connection, Is.EqualTo("keep-alive"));
        }

        [Test]
        public void ContainKey_AccessControlAllowOrigin_Equalling_Asterisk()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string accessCOntrolAllowOrigin = HeadersDict["Access-Control-Allow-Origin"];
            // Assert
            Assert.That(accessCOntrolAllowOrigin, Is.EqualTo("*"));
        }

        [Test]
        public void ContainKey_ContentType_Equalling_ApplicationJson()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string contentType = HeadersDict["Content-Type"];
            // Assert
            Assert.That(contentType, Is.EqualTo("application/json"));
        }

        [Test]
        public void ContainKey_Date_Containg_RealTime_Year()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string year = HeadersDict["Date"].Split(' ')[3];
            // Assert
            Assert.That(year, Is.EqualTo(DateTime.Today.Year.ToString()));
        }

        [Test]
        public void ContainKey_Server_Equalling_Nginx()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            // Credit to Tom for the header deserialisation
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();
            foreach (var item in response.Headers)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            string server = HeadersDict["Server"];
            // Assert
            Assert.That(server, Is.EqualTo("nginx"));
        }
    }
}