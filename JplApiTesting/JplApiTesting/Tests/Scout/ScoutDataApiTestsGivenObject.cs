using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;
using System;

namespace JplApiTesting.Tests.Scout
{
    //Test object data given object name
    public class ScoutDataApiTestsGivenObject
    {
        private static string _objectName = "A10nMaI";
        private ScoutNameQueryDataService _scoutService = new ScoutNameQueryDataService(_objectName);

        [Test]
        [Author("T Perera")]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScoutQueryName.signature.source, Is.EqualTo("NASA/JPL Scout API"));
        }

        [Test]
        [Author("T Perera")]
        public void CheckReturnsCorrectVersion()
        {
            Assert.That(_scoutService.dto.LatestScoutQueryName.signature.version, Is.EqualTo("1.2"));
        }

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

        [TestCase("A10o9AK")]
        [TestCase("A10o9AM")]
        [TestCase("P112eHp")]
        [TestCase("N00gs7n")]
        [TestCase("P112eHp")]
        [Author("T Perera")]
        public void CheckIfGivenNameIsValid(string ObjectName)
        {
            ScoutNameQueryDataService _scoutService = new ScoutNameQueryDataService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQueryName.error, Is.EqualTo(null));
        }

        [TestCase("A")]
        [TestCase("1")]
        [TestCase("22")]
        [TestCase("CC")]
        [TestCase("1D")]
        [Author("T Perera")]
        public void CheckIfGivenNameIsInValid(string ObjectName)
        {
            ScoutNameQueryDataService _scoutService = new ScoutNameQueryDataService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQueryName.error, Is.EqualTo("specified object does not exist"));
        }

        [Test]
        [Author("T Perera")]
        public void CheckNeoScoreReturnsValidScore()
        {
            Assert.That(int.Parse(_scoutService.dto.LatestScoutQueryName.neoScore), Is.InRange(0, 100));
        }

        [Test]
        [Author("T Perera")]
        public void CheckIEOScoreReturnsValidScore()
        {
            Assert.That(int.Parse(_scoutService.dto.LatestScoutQueryName.ieoScore), Is.InRange(0, 100));
        }

        [Test]
        [Author("T Perera")]
        public void CheckGEOScoreReturnsValidScore()
        {
            Assert.That(int.Parse(_scoutService.dto.LatestScoutQueryName.geocentricScore), Is.InRange(0, 100));
        }


    }
}