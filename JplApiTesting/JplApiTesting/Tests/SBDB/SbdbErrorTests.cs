using JplApiTesting.ApiObjectModels.SBDB.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.SBDB
{
    public class SbdbErrorTests
    {
        private SbdbErrorService _sbdbErrorService;
        private readonly string _invalidBodyNameReq = "?sstr=InvalidName";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _sbdbErrorService = new SbdbErrorService(_invalidBodyNameReq);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidBodyName_ReturnsCorrectCode()
        {
            Assert.That(_sbdbErrorService.DTO.SbdbError.code, Is.EqualTo("200"));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithInvalidBodyName_ReturnsCorrectMessage()
        {
            Assert.That(_sbdbErrorService.DTO.SbdbError.message, Is.EqualTo("specified object was not found"));
        }
    }
}