using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadGeneralServiceTests
    {
        private CadGeneralGetService _cadService;
        private const int _numOfResults = 10;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestparams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" },
            [RequestParametersTypes.Limit] = new RequestParameterInfo() { Label = CADConfigReader.LimitParam, Data = _numOfResults.ToString() }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadGeneralGetService(_requestparams);
        }

        [Test]
        public void CallingAPI_ReturnsCorrectNumOfItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_numOfResults));
        }
    }
}