using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadInvalidParamTests
    {
        private CadErrorRespService _cadService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadErrorRespService("?InvalidParameter");
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidParameters_ReturnsCorrectErrorCode()
        {
            Assert.That(_cadService.dto.ErrorCAD.code, Is.EqualTo("400"));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidParameters_ReturnsCorrectMessage()
        {
            Assert.That(_cadService.dto.ErrorCAD.message, Is.EqualTo("one or more query parameter was not recognized"));
        }
    }
}