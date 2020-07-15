using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryIPTests
	{
		//"2e-3"
		private SentryService sentryService = new SentryService(sentryIPValue: 2, exponent: 3);

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
		public void CountNumPotentialMeteorImpacts_GivenIP_ReturnsCountOfPredictedStrikes()
		{
			Assert.That(sentryService.dto.sentryIP.data.Count, Is.EqualTo(8));
		}

		[Test]
		[Author("N Sahota")]
		public void ValidateCountNumPotentialMeteorImpacts_GivenIP_ReturnsCountOfPredictedStrikes()
		{
			Assert.That(sentryService.dto.sentryIP.count.ToString(), Is.EqualTo("8"));
		}

	}
}