﻿using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadSpecificBodyTests
    {
        private CadSpecificBodyService _cadService;
        private const string _body = "Moon";
        private const int _expectedNUmOfDataItems = 2;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadSpecificBodyService(_body);
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