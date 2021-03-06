﻿using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadTestsAllData
    {
        private CadAllDataService _cadService;
        private const int _expectedNumOfFields = 12;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new CadAllDataService();
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectSignatureSource()
        {
            Assert.That(_cadService.dto.LatestCAD.signature.source, Is.EqualTo("NASA/JPL SBDB Close Approach Data API"));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectSignatureVersion()
        {
            Assert.That(_cadService.dto.LatestCAD.signature.version, Is.EqualTo("1.1"));
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsSameCountAsDataItems()
        {
            Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_cadService.dto.LatestCAD.data.Count));
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

        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Access-Control-Allow-Origin", "*")]
        [TestCase("Content-Type", "application/json")]
        [TestCase("Server", "nginx")]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectHeaderInformation(string headerKey, string expectedValue)
        {
            Assert.That(_cadService.callManager.GetContentTypeHeader()[headerKey], Is.EqualTo(expectedValue));
        }
    }
}