using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadSpecificClassTests
    {
        private CadSpecificClassService _cadService;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestparams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" },
            [RequestParametersTypes.Class] = new RequestParameterInfo() { Label = CADConfigReader.ClassParam, Data = "ATE" }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadSpecificClassService(_requestparams);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_cadService.dto.LatestCAD.data.Count));
        }
    }
}