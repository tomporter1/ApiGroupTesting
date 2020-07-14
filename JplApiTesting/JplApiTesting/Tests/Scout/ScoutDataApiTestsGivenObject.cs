using JplApiTesting.ApiObjectModels.Scout.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Scout
{
    //Test object data given object name
    public class ScoutDataApiTestsGivenObject
    {
        private static string objectName = "A10nMaI";
        public ScoutService _scoutService = new ScoutService(objectName);

        [Test]
        public void CheckReturnsCorrectCallSignature()
        {
            Assert.That(_scoutService.dto.LatestScoutQuery.signature.source, Is.EqualTo("NASA/JPL Scout API"));
        }

        [Test]
        public void CheckReturnsCorrectVersion()
        {
            Assert.That(_scoutService.dto.LatestScoutQuery.signature.version, Is.EqualTo("1.2"));
        }

        [Test]
        public void CheckReturnsPositiveVmag()
        {
            Assert.That(float.Parse(_scoutService.dto.LatestScoutQuery.Vmag), Is.GreaterThanOrEqualTo(0));
        }

        [TestCase("A10o9AK")]
        [TestCase("A10o9AM")]
        [TestCase("P112flU")]
        [TestCase("P212vDj")]
        [TestCase("C2XU6W2")]
        public void CheckIfGivenNameIsValid(string ObjectName)
        {
            ScoutService _scoutService = new ScoutService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQuery.error, Is.EqualTo(null));
        }

        [TestCase("A")]
        [TestCase("1")]
        [TestCase("22")]
        [TestCase("CC")]
        [TestCase("1D")]
        public void CheckIfGivenNameIsInValid(string ObjectName)
        {
            ScoutService _scoutService = new ScoutService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQuery.error, Is.EqualTo("specified object does not exist"));
        }
    }
}