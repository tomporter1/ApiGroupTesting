using JplApiTesting.ApiObjectModels.Fireball.DataHandling;
using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace JplApiTesting.Tests.Fireball
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApiGeneralShould
    {
        protected const int ExpectedNumFields = 9;
        protected const int NumToQuery = 20;
        protected FireballService _fireballService = null;

        [SetUp]
        [Author("K McEvaddy")]
        public virtual void Setup()
        {
            _fireballService = new FireballService(NumToQuery);
        }

        [Test]
        [Author("K McEvaddy")]
        public void Contains_CorrectNumberOfFields()
        {
            Assert.That(_fireballService.GetFields().Count, Is.EqualTo(ExpectedNumFields));
        }

        [Test]
        [Author("K McEvaddy")]
        public void Contains_APopulatedListOfFields()
        {
            Assert.That(_fireballService.GetFields(), Is.Not.Empty);
        }

        [TestCase(7)]
        [TestCase(19)]
        [TestCase(0)]
        [TestCase(13)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_CountElements(in int index)
        {
            Assert.That(_fireballService.GetData()[index].Count, Is.EqualTo(ExpectedNumFields));
        }

        [Test]
        [Author("K McEvaddy")]
        public void Signature_Contains_ProperApiName()
        {
            Assert.That(_fireballService.GetSignature().source, Is.EqualTo("NASA/JPL Fireball Data API"));
        }

        // Assert that "data"[TEST_CASE_INT]."date" is a valid date
        [TestCase(0)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidDate_Year(in int index)
        {
            int year = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[0].Split('-')[0]);
            Assert.That(year, Is.GreaterThanOrEqualTo(DateTime.MinValue.Year));
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(17)]
        [TestCase(10)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Hour(in int index)
        {
            int hour = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[0]);
            Assert.That(hour, Is.LessThan(24));
        }

        [TestCase(0)]
        [TestCase(6)]
        [TestCase(19)]
        [TestCase(14)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveHour(in int index)
        {
            int hour = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[0]);
            Assert.That(hour, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(4)]
        [TestCase(11)]
        [TestCase(15)]
        [TestCase(18)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Minutes(in int index)
        {
            int minute = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[1]);
            Assert.That(minute, Is.LessThan(60));
        }

        [TestCase(1)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(15)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveMinute(in int index)
        {
            int minute = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[1]);
            Assert.That(minute, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(2)]
        [TestCase(6)]
        [TestCase(17)]
        [TestCase(12)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidTime_Seconds(in int index)
        {
            int second = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[2]);
            Assert.That(second, Is.LessThan(60));
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(17)]
        [TestCase(10)]
        [Author("K McEvaddy")]
        public void EachDatum_Time_Contains_PositiveSecond(in int index) 
        {
            int second = int.Parse(_fireballService.GetData()[index][(int)EFields.date].Split(' ')[1].Split(':')[2]);
            Assert.That(second, Is.GreaterThanOrEqualTo(0));
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(16)]
        [TestCase(14)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidLatitudeDirection(in int index)
        {
            List<string> latitudeDirections = Enum.GetNames(typeof(ELatitudeDirectionNames)).ToList();
            string latitudeDirection = _fireballService.GetData()[index][(int)EFields.lat_dir];
            Assert.That(latitudeDirections, Does.Contain(latitudeDirection));
        }

        [TestCase(18)]
        [TestCase(11)]
        [TestCase(1)]
        [TestCase(5)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidLongitudeDirection(in int index) 
        {
            List<string> longitudeDirections = Enum.GetNames(typeof(ELongitudeDirectionNames)).ToList();
            string longitudeDirection = _fireballService.GetData()[index][(int)EFields.lon_dir];
            Assert.That(longitudeDirections, Does.Contain(longitudeDirection));
        }
    }
}