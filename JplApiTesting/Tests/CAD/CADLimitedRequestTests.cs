using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadLimitedRequestTests
    {
        private CadLimitService _cadService;
        private const int _limit = 10;
        private const int _expectedNumOfFields = 12;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" },
            [RequestParametersTypes.Limit] = new RequestParameterInfo() { Label = CADConfigReader.LimitParam, Data = _limit.ToString() }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadLimitService(_requestParams);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectCountOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.LessThanOrEqualTo(_limit));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(_cadService.dto.LatestCAD.data.Count, Is.LessThanOrEqualTo(_limit));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberOfFields()
        {
            Assert.That(_cadService.dto.LatestCAD.fields.Count, Is.EqualTo(_expectedNumOfFields));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberFieldsInEachDataItem()
        {
            int numOfFields = _cadService.dto.LatestCAD.fields.Count;
            Assert.That(_cadService.AllDataItemsHaveSameNumOfFields(numOfFields));
        }
    }
}