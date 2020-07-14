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
    public class ScoutDataApiTests
    {
        private ScoutService _scoutService = new ScoutService();

        [Test]
        public void CheckReturnsCorrectCallSignature()   
        {
            Assert.That(_scoutService.dto.LatestScout.signature.source,Is.EqualTo("NASA/JPL Scout API"));
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
        }



    }
}
