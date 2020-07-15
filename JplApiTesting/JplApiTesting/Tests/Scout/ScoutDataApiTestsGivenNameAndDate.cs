using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Scout
{
    public class ScoutDataApiTestsGivenNameAndDate
    {
        private static string Name = "A10nMaI";
        // select a date that's either one month in the future or in the past of the current day
        private static string date = "2020-07-22"; // Format = "YYYY-MM-DD"
        private ScoutEphemerisDataService _scoutService =
            new ScoutEphemerisDataService(Name, date);

        [TestCase("Content-Type", "application/json")]
        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Server", "nginx")]
        public void CheckReturnsCorrectHeader(string key, string expected)
        {
            Assert.That(_scoutService.callManager.GetContentTypeHeader()[key], Is.EqualTo(expected));
        }

        [Test]
        public void CheckHeaderReturnsCorrectDate()
        {
            string date = DateTime.Now.AddHours(-1).ToString("r");
            Assert.That(_scoutService.callManager.GetContentTypeHeader()["Date"], Is.EqualTo(date));
        }

        [Test]
        public void CheckOrbitCountReturnsCorrectCount()
        {
            Assert.That(_scoutService.dto.LatestScoutEphemeris.orbitcount, Is.EqualTo(1000));
        }
    }

}
