using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryRemovedTests
	{
		private SentryRemovedService sentryRemovedService;

		[TestCase("Y")]
		[TestCase("true")]
		[TestCase("1")]
		[Author("N Sahota")]
		public void CountNumImpactsRemoved_ReturnsCountOfRemovedMeteors(string showRemoved)
		{
			sentryRemovedService = new SentryRemovedService(showRemoved);

			string countGivenInAPI = sentryRemovedService.dto.SentryRemoved.count;
			Assert.That(sentryRemovedService.dto.SentryRemoved.data.Count.ToString(), Is.EqualTo(countGivenInAPI));
		}

		[TestCase("N")]
		[TestCase("false")]
		[TestCase("0")]
		[Author("N Sahota")]
		public void CountNumImpacts_ReturnsCountOfMeteors(string showRemoved)
		{
			sentryRemovedService = new SentryRemovedService(showRemoved);

			string countGivenInAPI = sentryRemovedService.dto.SentryRemoved.count;
			Assert.That(sentryRemovedService.dto.SentryRemoved.data.Count.ToString(), Is.EqualTo(countGivenInAPI));
		}

		[TestCase("Transfer-Encoding", "chunked")]
		[TestCase("Connection", "keep-alive")]
		[TestCase("Access-Control-Allow-Origin", "*")]
		[TestCase("Content-Type", "application/json")]
		[TestCase("Server", "nginx")]
		[Author("N Sahota")]
		public void CallingAPI_ReturnsCorrectHeaderInfo(string headerKey, string expectedValue)
		{
			sentryRemovedService = new SentryRemovedService("true");
			Assert.That(sentryRemovedService.sentryCallManager.GetContentTypeHeader()[headerKey], Is.EqualTo(expectedValue));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureSource_ReturnsCorrectSource()
		{
			sentryRemovedService = new SentryRemovedService("true");
			Assert.That(sentryRemovedService.dto.SentryRemoved.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureVersion_ReturnsCorrectVersion()
		{
			sentryRemovedService = new SentryRemovedService("true");
			Assert.That(sentryRemovedService.dto.SentryRemoved.signature.version.ToString(), Is.EqualTo("1.1"));
		}
	}
}