using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadDateFilterTests
    {
        private CadDateFilteredService _cadService;
        private readonly string _minDate = "2020-06-01", _maxDate = "2020-06-30";
        private const int _numberOfCloseApproachItemsInJune2020 = 82;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadDateFilteredService(_minDate, _maxDate);
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