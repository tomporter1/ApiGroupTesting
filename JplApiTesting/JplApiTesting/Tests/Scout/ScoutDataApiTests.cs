using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Scout
{
    public class ScoutDataApiTests
    {
        private ScoutService _scoutService = new ScoutService();

        [Test]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScout.signature.source.ToString(), Is.EqualTo("NASA/JPL Scout API"));
        }
    }
}