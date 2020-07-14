using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.Tests.CAD
{
    public class CADLimitedRequestTests
    {
        private CADService _cadService;
        private const int _limit = 10;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CADService(_limit);
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.LessThanOrEqualTo(_limit));
        }

        [Test]
        public void FrameworkThrowsException_WithNegativeLimit()
        {
           Assert.That(() => new CADService(-1), Throws.ArgumentException);
        }
    }
}