using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadSpecificClassTests
    {
        private CadSpecificClassService _cadService;
        private const string _class = "ATE";

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadSpecificClassService(_class);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_cadService.dto.LatestCAD.data.Count));
        }
    }
}