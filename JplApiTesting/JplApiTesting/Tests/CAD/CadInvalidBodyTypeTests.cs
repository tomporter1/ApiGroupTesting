using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadInvalidBodyTypeTests
    {
        private CadErrorRespService _cadService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadErrorRespService("?body=Invalid");
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidBodyParameter_ReturnsCorrectErrorCode()
        {
            Assert.That(_cadService.dto.ErrorCAD.code, Is.EqualTo("400"));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidBodyParameter_ReturnsCorrectMessage()
        {
            Assert.That(_cadService.dto.ErrorCAD.message, Is.EqualTo("body not found"));
        }
    }
}