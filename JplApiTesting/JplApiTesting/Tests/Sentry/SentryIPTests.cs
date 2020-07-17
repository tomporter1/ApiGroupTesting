using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryIPTests
	{
		//"2e-3"
		private SentryIPService sentryService;

		private readonly string meteorIPValue = "2";
		private readonly string exponent = "3";

		[OneTimeSetUp]
		public void Setup()
		{
			sentryService = new SentryIPService(sentryIPValue: meteorIPValue, exponent);
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
		public void CountNumPotentialMeteorImpacts_GivenIP_ReturnsCountOfPredictedStrikes()
		{
			int countGivenInAPI = sentryService.dto.SentryIP.count;
			Assert.That(sentryService.dto.SentryIP.data.Count, Is.EqualTo(countGivenInAPI));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureSource_ReturnsCorrectSource()
		{
			Assert.That(sentryService.dto.SentryIP.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureVersion_ReturnsCorrectVersion()
		{
			Assert.That(sentryService.dto.SentryIP.signature.version.ToString(), Is.EqualTo("1.1"));
		}
	}
}