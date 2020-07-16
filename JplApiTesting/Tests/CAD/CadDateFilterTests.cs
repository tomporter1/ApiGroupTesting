using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadDateFilterTests
    {
        private CadDateFilteredService _cadService;
        private readonly string _minDate = "2020-06-01", _maxDate = "2020-06-30";
        private const int _numberOfCloseApproachItemsInJune2020 = 82;

        private readonly Dictionary<RequestParametersTypes, RequestParameterInfo> _requestparams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
        {
            [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" },
            [RequestParametersTypes.MinDate] = new RequestParameterInfo() { Label = CADConfigReader.MinDateParam, Data = "2020-06-01" },
            [RequestParametersTypes.MaxDate] = new RequestParameterInfo() { Label = CADConfigReader.MaxDateParam, Data = "2020-06-30" }
        };

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadDateFilteredService(_requestparams);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithFilteredDates_ReturnsCorrectCount()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_numberOfCloseApproachItemsInJune2020));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithFilteredDates_ReturnsCorrectNUmOfDataItems()
        {
            Assert.That(_cadService.dto.LatestCAD.data.Count, Is.EqualTo(_numberOfCloseApproachItemsInJune2020));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_WithFilteredDates_ReturnsDataItemsWithinDateRange()
        {
            Assert.That(_cadService.AllDatesAreWithinRange(_minDate, _maxDate));
        }
    }
}