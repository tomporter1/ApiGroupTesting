using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;
using System;
using System.Linq;

namespace JplApiTesting.Tests.Scout
{

    // Test all available summary data
    public class ScoutDataApiTests
    {
        private ScoutAllDataService _scoutService = new ScoutAllDataService();
        [Test]
        [Author("T Perera")]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.source, Is.EqualTo("NASA/JPL Scout API"));
        }

        [Test]
        [Author("T Perera")]
        public void CheckReturnsCorrectVersion()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.version, Is.EqualTo("1.2"));
        }

        [Test]
        [Author("T Perera")]
        public void CheckReturnsCorrectDataCount()
        {
            Assert.That(_scoutService.dto.LatestScout.count, Is.EqualTo(_scoutService.dto.LatestScout.data.Count().ToString()));
        }

        [TestCase("Content-Type", "application/json")]
        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Server", "nginx")]
        [Author("T Porter")]
        public void CheckReturnsCorrectHeader(string key, string expected)
        {
            Assert.That(_scoutService.callManager.GetContentTypeHeader()[key], Is.EqualTo(expected));
        }

        [Test]
        [Author("T Perera")]
        public void CheckHeaderReturnsCorrectDate()
        {
            string date = DateTime.Now.AddHours(-1).ToString("r").Remove(22, 7);
            Assert.That(_scoutService.callManager.GetContentTypeHeader()["Date"],Does.Contain(date));
        }
    }
}