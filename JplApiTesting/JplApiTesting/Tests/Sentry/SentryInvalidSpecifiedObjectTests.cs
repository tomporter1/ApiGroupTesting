using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryInvalidSpecifiedObjectTests
	{
        private SentryErrorService sentryErrorService;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            sentryErrorService = new SentryErrorService("?InavlidSpecifiedSentryObject");
        }

        [Test]
        [Author("N Sahota")]
        public void ApiCall_WithInavlidSpecifiedSentryObject_ReturnsErrorCode()
        {
            Assert.That(sentryErrorService.dto.ErrorSentry.code, Is.EqualTo("400"));
        }

        [Test]
        [Author("N Sahota")]
        public void ApiCall_WithInvalidParameters_ReturnsCorrectMessage()
        {
            Assert.That(sentryErrorService.dto.ErrorSentry.message, Is.EqualTo("invalid character in designation"));
        }
    }
}
