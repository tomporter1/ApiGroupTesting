﻿using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadLimitedRequestTests
    {
        private CADService _cadService;
        private const int _limit = 10;
        private const int _expectedNumOfFields = 12;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CADService(_limit);
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectCountOfDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.LessThanOrEqualTo(_limit));
        }
        
        [Test]
        public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
        {
            Assert.That(_cadService.dto.LatestCAD.data.Count, Is.LessThanOrEqualTo(_limit));
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectNumberOfFields()
        {
            Assert.That(_cadService.dto.LatestCAD.fields.Count, Is.EqualTo(_expectedNumOfFields));
        }

        [Test]
        public void FrameworkThrowsException_WithNegativeLimit()
        {
           Assert.That(() => new CADService(-1), Throws.ArgumentException.And.Message.EqualTo("The limit for the request cannot be negative"));
        }

        [Test]
        public void CallingTheAPI_ReturnsCorrectNumberFieldsInEachDataItem()
        {
            int numOfFields = _cadService.dto.LatestCAD.fields.Count;
            Assert.That(_cadService.AllDataItemsHaveSameNumOfFields(numOfFields));
        }
    }
}