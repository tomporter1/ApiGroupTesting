using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;
using System;

namespace JplApiTesting.Tests.Scout
{
    public class ScoutDataApiTestsGivenNameAndDate
    {
        private static string _name = "A10nMaI";

        // select a date that's either one month in the future or in the past of the current day
        private static string _date = "2020-07-22"; // Format = "YYYY-MM-DD"

        private ScoutEphemerisDataService _scoutService =
            new ScoutEphemerisDataService(_name, _date);

        [TestCase("Content-Type", "application/json")]
        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Server", "nginx")]
        [Author("T Perera")]
        public void CheckReturnsCorrectHeader(string key, string expected)
        {
            Assert.That(_scoutService.callManager.GetContentTypeHeader()[key], Is.EqualTo(expected));
        }

        [Test]
        [Author("T Perera")]
        public void CheckHeaderReturnsCorrectDate()
        {
            string date = DateTime.Now.AddHours(-1).ToString("r").Remove(22, 7);
            Assert.That(_scoutService.callManager.GetContentTypeHeader()["Date"], Does.Contain(date));
        }

        [Test]
        [Author("T Perera")]
        public void CheckOrbitCountReturnsCorrectCount()
        {
            Assert.That(_scoutService.dto.LatestScoutEphemeris.orbitcount, Is.EqualTo(1000));
        }

        [TestCase("2021-07-11", "'eph-start' is more than 30 days in the future")]
        [TestCase("2019-07-11", "'eph-start' is more than 30 days in the past")]
        [TestCase("07-11-2000", "invalid value specified for query parameter 'eph-start': invalid datetime specified" +
            " (expected 'YYYY-MM-DD', 'YYYY-MM-DDThh:mm:ss', 'YYYY-MM-DD_hh:mm:ss' or 'YYYY-MM-DD hh:mm:ss')")]
        [Author("T Perera")]
        public void CheckMessageReturnsCorrectErrorGivenInvalidDate(string givenDate, string expected)
        {
            ScoutEphemerisDataService _scoutService = new ScoutEphemerisDataService(_name, givenDate);
            Assert.That(_scoutService.dto.LatestScoutEphemeris.message, Is.EqualTo(expected));
        }

        [TestCase("A")]
        [TestCase("1")]
        [TestCase("22")]
        [TestCase("CC")]
        [TestCase("1D")]
        [Author("T Perera")]
        public void CheckMessageReturnsCorrectErrorGivenInvalidName(string givenName)
        {
            ScoutEphemerisDataService _scoutService = new ScoutEphemerisDataService(givenName, _date);
            Assert.That(_scoutService.dto.LatestScoutEphemeris.error, Is.EqualTo("specified object does not exist"));
        }
    }
}