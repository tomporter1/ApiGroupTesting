using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.Tests.CAD
{
    public class CadTests
    {
        private CADService _cadService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CADService();
        }

        [Test]
        public void CallingTheAPI_ReturnsSuccessCode()
        {
            Assert.That(_cadService.dto.LatestCAD.signature.source, Is.EqualTo("NASA/JPL SBDB Close Approach Data API"));
        }
    }
}