using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadTests
    {
        private CADService _cadService;
        private const int _expectedNumOfFields = 12;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CADService("All");
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectSignatureSource() 
        {
            Assert.That(_cadService.dto.LatestCAD.signature.source, Is.EqualTo("NASA/JPL SBDB Close Approach Data API"));
        }
        
        [Test]
        public void CallingTheAPI_ReturnsCorrectSignatureVersion() 
        {
            Assert.That(_cadService.dto.LatestCAD.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        public void CallingTheAPI_ReturnsSameCountAsDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_cadService.dto.LatestCAD.data.Count));
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectNumberOfFields()
        {
            Assert.That(_cadService.dto.LatestCAD.fields.Count, Is.EqualTo(_expectedNumOfFields));
        }
    }
}