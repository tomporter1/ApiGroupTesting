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
        // Very duplicated: just use test cases in future.

        [Test]
        public void ContainKey_TransferEncoding_Equalling_Chunked()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
            // Assert
            Assert.That(HeadersDict["Transfer-Encoding"], Is.EqualTo("chunked"));
        }

        [Test]
        public void ContainKey_Connection_Equalling_KeepAlive()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
            // Assert
            Assert.That(HeadersDict["Connection"], Is.EqualTo("keep-alive"));
        }

        [Test]
        public void ContainKey_AccessControlAllowOrigin_Equalling_Asterisk()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
            // Assert
            Assert.That(HeadersDict["Access-Control-Allow-Origin"], Is.EqualTo("*"));
        }

        [Test]
        public void ContainKey_ContentType_Equalling_ApplicationJson()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
            // Assert
            Assert.That(HeadersDict["Content-Type"], Is.EqualTo("application/json"));
        }

        [Test]
        public void ContainKey_Date_Containg_RealTime_Year()
        {
            // Arrange, Act
            IRestClient client = new RestClient(FireballConfigReader.BaseUrl);
            IRestRequest request = new RestRequest("$limit=20");
            IRestResponse response = client.Execute(request, Method.GET);
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
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
            Dictionary<string, string> HeadersDict = JplApiTesting.ApiObjectModels.TestTools.GetContentTypeHeader(response.Headers);
            // Assert
            Assert.That(HeadersDict["Server"], Is.EqualTo("nginx"));
        }
    }
}