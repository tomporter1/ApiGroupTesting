using JplApiTesting.ApiObjectModels.Fireball.DataHandling;
using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(16)]
        [TestCase(14)]
        [Author("K McEvaddy")]
        public void EachDatum_Contains_ValidLatitudeDirection(in int index)
        {
            List<string> latitudeDirections = Enum.GetNames(typeof(ELatitudeDirectionNames)).ToList();
            string latitudeDirection = _fireballService.GetDataSubElementAt(index, EFields.lat_dir);
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
            string longitudeDirection = _fireballService.GetDataSubElementAt(index, EFields.lon_dir);
            Assert.That(longitudeDirections, Does.Contain(longitudeDirection));
        }
    }
}