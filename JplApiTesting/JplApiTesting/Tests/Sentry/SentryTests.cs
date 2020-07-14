using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
    public class SentryTests
    {
        private SentryService sentryService = new SentryService();

        [Test]
        public void CheckCountField_ReturnsAmount()
        {
            Assert.That(sentryService.dto.LatestSentry.count.ToString(), Is.EqualTo("1021"));
        }
    }
}