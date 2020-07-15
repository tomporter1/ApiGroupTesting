using JplApiTesting.ApiObjectModels.Fireball.DataHandling;
using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Fireball.Data
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApi_EachDatum_Time_Should
    {
        protected const int NumToQuery = 20;
        protected const int HoursPerDay = 24;
        FireballService _fireballService = null;

        [SetUp]
        [Author("K McEvaddy")]
        public virtual void Setup()
        {
            _fireballService = new FireballService(NumToQuery);
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(17)]
        [TestCase(10)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Hour(in int index)
        {
            int hour = _fireballService.GetHourAt(index);
            Assert.That(hour, Is.LessThan(HoursPerDay));
        }

        [TestCase(0)]
        [TestCase(6)]
        [TestCase(19)]
        [TestCase(14)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveHour(in int index)
        {
            int hour = _fireballService.GetHourAt(index);
            Assert.That(hour, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(4)]
        [TestCase(11)]
        [TestCase(15)]
        [TestCase(18)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Minutes(in int index)
        {
            int minute = _fireballService.GetMinuteAt(index);
            Assert.That(minute, Is.LessThan(60));
        }

        [TestCase(1)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(15)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveMinute(in int index)
        {
            int minute = _fireballService.GetMinuteAt(index);
            Assert.That(minute, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(2)]
        [TestCase(6)]
        [TestCase(17)]
        [TestCase(12)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Seconds(in int index)
        {
            int second = _fireballService.GetSecondAt(index);
            Assert.That(second, Is.LessThan(60));
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(17)]
        [TestCase(10)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveSecond(in int index)
        {
            int second = _fireballService.GetSecondAt(index);
            Assert.That(second, Is.GreaterThanOrEqualTo(0));
        }
    }
}
