using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryErrorTests
	{
		private SentryErrorService sentryErrorService;

		[TestCase("SentrySpecifiedObject", "InavlidSpecifiedSentryObject", "invalid designation")]
		[TestCase("SentrySpecifiedObject", "sd544££22", "invalid character in designation")]
		[Author("N Sahota")]
		public void navlidSpecifiedSentryObject_ReturnsErrorCode(string apiUnderTest, string invalidData, string expected)
		{
			sentryErrorService = new SentryErrorService(apiUnderTest, invalidData);
			Assert.That(sentryErrorService.dto.ErrorSentry.message, Is.EqualTo(expected));

			Assert.That(sentryErrorService.dto.ErrorSentry.code, Is.EqualTo("400"));
		}

		[TestCase("SentryIP", "1", "25")]
		[TestCase("SentryIP", "102", "786")]
		[TestCase("SentryIP", "dfdf", "fgwe")]
		[TestCase("SentryIP", "525gt", "32rt")]
		[TestCase("SentryIP", "$£$", "?*(")]
		[TestCase("SentryIP", " ", " ")]
		[Author("N Sahota")]
		public void InavlidSentryIP_ReturnsErrorCode(string apiUnderTest, string invalidIP, string invalidExponent)
		{
			sentryErrorService = new SentryErrorService(apiUnderTest, invalidIP, invalidExponent);
			Assert.That(sentryErrorService.dto.ErrorSentry.message,
				Is.EqualTo("invalid value specified for query parameter 'ip-min': invalid ip-min value (expecting a positive number between 1e-10 and 1.0)"));

			Assert.That(sentryErrorService.dto.ErrorSentry.code, Is.EqualTo("400"));
		}

		[TestCase("SentryRemoved", "42")]
		[TestCase("SentryRemoved", " ")]
		[TestCase("SentryRemoved", "randomletters")]
		[TestCase("SentryRemoved", "%^$£&(")]
		[Author("N Sahota")]
		public void InavlidSentryRemoved_ReturnsErrorCode(string apiUnderTest, string removedDataInput)
		{
			sentryErrorService = new SentryErrorService(apiUnderTest, removedDataInput);
			Assert.That(sentryErrorService.dto.ErrorSentry.message,
				Is.EqualTo("boolean value must be 'true', 'false', 'Y', 'N', '1', or '0'"));

			Assert.That(sentryErrorService.dto.ErrorSentry.code, Is.EqualTo("400"));
		}
	}
}