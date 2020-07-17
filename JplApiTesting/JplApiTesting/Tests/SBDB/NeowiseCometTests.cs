using JplApiTesting.ApiObjectModels.SBDB.Services;
using NUnit.Framework;
using System;

namespace JplApiTesting.Tests.SBDB
{
    public class NeowiseCometTests
    {
        private SbdbSpecificSmallBodyService _sbdbService;
        private readonly string _bodyName = "2020 F3";

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _sbdbService = new SbdbSpecificSmallBodyService(_bodyName);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectComet()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo._object.fullname, Is.EqualTo("C/2020 F3 (NEOWISE)"));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectSignature()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo.signature.source, Is.EqualTo("NASA/JPL Small-Body Database (SBDB) API"));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectSource()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo.orbit.source, Is.EqualTo("JPL"));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectFirstObservation()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo.orbit.first_obs, Is.EqualTo("2020-03-27"));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectOrbitProducer()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo.orbit.producer, Is.EqualTo("Otto Matic"));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectSPKID()
        {
            Assert.That(_sbdbService.DTO.SbdbInfo._object.spkid, Is.EqualTo("1003667"));
        }

        [TestCase("Content-Type", "application/json")]
        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Server", "nginx")]
        [Author("T Perera")]
        public void CallingTheAPI_ReturnsCorrectHeader(string key, string expected)
        {
            Assert.That(_sbdbService.callManager.GetContentTypeHeader()[key], Is.EqualTo(expected));
        }

        [Test]
        [Author("T Perera")]
        public void CallingTheAPI_HeaderReturnsCorrectDate()
        {
            string date = DateTime.Now.AddHours(-1).ToString("r").Remove(22, 7);
            Assert.That(_sbdbService.callManager.GetContentTypeHeader()["Date"], Does.Contain(date));
        }
    }
}