using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadSpecificBodyTests
    {
        private CadSpecificBodyService _cadService;
        private const int _expectedNUmOfDataItems = 2;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestparams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "Moon" }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadSpecificBodyService(_requestparams);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_expectedNUmOfDataItems).And.EqualTo(_cadService.dto.LatestCAD.data.Count));
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