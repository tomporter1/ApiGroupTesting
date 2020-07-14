using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JplApiTesting.ApiObjectModels.Scout;
using System.Threading.Tasks;
using NUnit.Framework;
using JplApiTesting.ApiObjectModels.Scout.Services;

namespace JplApiTesting.Tests.Scout
{
    public class ScoutDataApiTestsGivenObject
    {
        static string objectName = "A10nMaI";
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
            Assert.That(float.Parse(_scoutService.dto.LatestScoutQuery.Vmag),Is.GreaterThanOrEqualTo(0));
        }

        [TestCase("A10o9AK", null)]
        [TestCase("A10o9AM", null)]
        [TestCase("P112flU", null)]
        [TestCase("P212vDj", null)]
        [TestCase("C2XU6W2", null)]
        public void CheckIfGivenNameIsValid(string ObjectName, string result)
        {
            ScoutService _scoutService = new ScoutService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQuery.error, Is.EqualTo(result));
        }

        [TestCase("A", "specified object does not exist")]
        [TestCase("1", "specified object does not exist")]
        [TestCase("22", "specified object does not exist")]
        [TestCase("CC", "specified object does not exist")]
        [TestCase("1D", "specified object does not exist")]
        public void CheckIfGivenNameIsInValid(string ObjectName, string result)
        {
            ScoutService _scoutService = new ScoutService(ObjectName);
            Assert.That(_scoutService.dto.LatestScoutQuery.error, Is.EqualTo(result));
        }


    }
}
