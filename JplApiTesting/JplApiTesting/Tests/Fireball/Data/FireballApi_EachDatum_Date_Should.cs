using JplApiTesting.ApiObjectModels.Fireball.DataHandling;
using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;
using System;

namespace JplApiTesting.Tests.Fireball.Data
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApi_EachDatum_Date_Should
    {
        protected FireballService _fireballService = null;
        protected const int NumToQuery = 20;
        protected const int FirstDayOfMonth = 1;
        protected const int LastPossibleDayOfMonth = 31;

        [SetUp]
        [Author("K McEvaddy")]
        public virtual void Setup()
        {
            _fireballService = new FireballService(NumToQuery);
        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(16)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Year_GreaterThanOrEqualToMin(in int index)
        {
            int year = _fireballService.GetYearAt(index);
            Assert.That(year, Is.GreaterThanOrEqualTo(DateTime.MinValue.Year));
        }

        [TestCase(2)]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(16)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Year_LessThanOrEqualToMax(in int index)
        {
            int year = _fireballService.GetYearAt(index);
            Assert.That(year, Is.LessThanOrEqualTo(DateTime.MaxValue.Year));
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(11)]
        [TestCase(19)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Month_GreaterThanOrEqualToMin(in int index)
        {
            int month = _fireballService.GetMonthAt(index);
            Assert.That(month, Is.GreaterThanOrEqualTo(DateTime.MinValue.Month));
        }

        [TestCase(2)]
        [TestCase(6)]
        [TestCase(13)]
        [TestCase(18)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Month_LessThanOrEqualToMax(in int index)
        {
            int month = _fireballService.GetMonthAt(index);
            Assert.That(month, Is.LessThanOrEqualTo(DateTime.MaxValue.Month));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(10)]
        [TestCase(15)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Day_GreaterThanOrEqualToMin(in int index)
        {
            int day = _fireballService.GetDayAt(index);
            Assert.That(day, Is.GreaterThanOrEqualTo(FirstDayOfMonth));
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(11)]
        [TestCase(17)]
        [Author("K McEvaddy")]
        public void Contains_ValidDate_Day_LessThanOrEqualToMax(in int index) 
        {
            int day = _fireballService.GetDayAt(index);
            Assert.That(day, Is.LessThanOrEqualTo(LastPossibleDayOfMonth));
        }
    }
}
