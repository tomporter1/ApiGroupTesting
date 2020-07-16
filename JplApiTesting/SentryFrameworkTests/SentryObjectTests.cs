using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;
using System;

namespace JplApiTesting.Tests.Sentry
{
    public class SentryObjectTests
    {
        //obtain details related to a specified Sentry object
        private SentrySpecifiedObjectService sentryService;

        private readonly string meteorObjectName = "99942";

        [OneTimeSetUp]
        public void Setup()
        {
            sentryService = new SentrySpecifiedObjectService(sentryObjectName: meteorObjectName);
        }

        [TestCase("Transfer-Encoding", "chunked")]
        [TestCase("Connection", "keep-alive")]
        [TestCase("Access-Control-Allow-Origin", "*")]
        [TestCase("Content-Type", "application/json")]
        [TestCase("Server", "nginx")]
        [Author("N Sahota")]
        public void CallingAPI_ReturnsCorrectHeaderInfo(string headerKey, string expectedValue)
        {
            Assert.That(sentryService.sentryCallManager.GetContentTypeHeader()[headerKey], Is.EqualTo(expectedValue));
        }

        [Test]
        [Author("N Sahota")]
        public void MassIsOverZero_MeteorMass_ReturnsTrue()
        {
            string mass = sentryService.dto.SpecifiedSentry.summary.mass.ToString();
            Assert.That(sentryService.CheckMassIsOverZeroSpecifiedObject(mass), Is.True);
        }

        [Test]
        [Author("N Sahota")]
        public void CountNumPotentialMeteorImpacts_ReturnsCountOfPredictedStrikes()
        {
            int countGivenInAPI = Int32.Parse(sentryService.dto.SpecifiedSentry.summary.n_imp);
            Assert.That(sentryService.dto.SpecifiedSentry.data.Count, Is.EqualTo(countGivenInAPI));
        }

        [Test]
        [Author("N Sahota")]
        public void FileSignatureSource_ReturnsCorrectSource()
        {
            Assert.That(sentryService.dto.SpecifiedSentry.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
        }

        [Test]
        [Author("N Sahota")]
        public void FileSignatureVersion_ReturnsCorrectVersion()
        {
            Assert.That(sentryService.dto.SpecifiedSentry.signature.version.ToString(), Is.EqualTo("1.1"));
        }

        [Test]
        [Author("N Sahota")]
        public void ComparePredictedImpactDates_ReturnFalseIfDiffrent()
        {
            //Output should be false according to the API doc, A potential impact cannot be the same for one meteor
            string firstDate = sentryService.dto.SpecifiedSentry.data[0].date;
            string secondDate = sentryService.dto.SpecifiedSentry.data[1].date;

            Assert.That(sentryService.CompareDatesSpecifiedObject(firstDate, secondDate), Is.False);
        }
    }
}