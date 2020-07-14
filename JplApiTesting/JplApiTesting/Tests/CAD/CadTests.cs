using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

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
        public void CallingTheAPI_ReturnsCorrectSignature() 
        {
            Assert.That(_cadService.dto.LatestCAD.signature.source, Is.EqualTo("NASA/JPL SBDB Close Approach Data API"));
            Assert.That(_cadService.dto.LatestCAD.signature.version, Is.EqualTo("1.1"));
        }
    }
}