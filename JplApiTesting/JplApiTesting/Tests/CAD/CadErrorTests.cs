using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadErrorTests
    {
        private CadCustomRequestService _cadService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadCustomRequestService("?InvalidParameter");
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

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyRequestString()
        {
            Assert.That(() => new CadCustomRequestService(""), Throws.ArgumentException.And.Message.EqualTo("The request cannot be an empty string"));
        }
    }
}