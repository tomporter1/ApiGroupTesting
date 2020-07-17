using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadInvalidBodyTypeTests
    {
        private CadErrorRespService _cadService;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "Invalid" }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadErrorRespService(_requestParams);
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