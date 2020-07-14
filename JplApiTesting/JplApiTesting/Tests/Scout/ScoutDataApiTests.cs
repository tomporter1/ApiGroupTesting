using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;
using System.Linq;

namespace JplApiTesting.Tests.Scout
{

    // Test all available summary data
    public class ScoutDataApiTests
    {
        private ScoutService _scoutService = new ScoutService();
        [Test]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.source, Is.EqualTo("NASA/JPL Scout API"));
        }

        [Test]
        public void CheckReturnsCorrectVersion()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.version, Is.EqualTo("1.2"));
        }

        [Test]
        public void CheckReturnsCorrectDataCount()
        {
            Assert.That(_scoutService.dto.LatestScout.count, Is.EqualTo(_scoutService.dto.LatestScout.data.Count().ToString()));
        [Test]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.source.ToString(), Is.EqualTo("NASA/JPL Scout API"));
        }
    }
}