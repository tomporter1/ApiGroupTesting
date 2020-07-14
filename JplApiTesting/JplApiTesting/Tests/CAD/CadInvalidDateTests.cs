using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadInvalidDateTests
    {      
        private CadErrorRespService _cadService;
        private readonly string _minDate = "2020-07-32", _maxDate = "2020-07-38";

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadErrorRespService($"?body=All&date-min={_minDate}&date-max={_maxDate}");
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
            Assert.That(_cadService.dto.ErrorCAD.message, Is.EqualTo("invalid value specified for query parameter 'date-min': invalid day (32) in datetime value"));
        }
    }
}