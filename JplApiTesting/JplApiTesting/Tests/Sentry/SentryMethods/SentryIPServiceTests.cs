using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryIPServiceTests
	{
		[TestCase("random", "letters")]
		[TestCase("$%g", "*(84")]
		[TestCase("-43", "256")]
		public void SentryIPServiceMethod_GivenInvalidInput_ThrowsArgumentException(string invalidDataInput, string invalidExponent)
		{
			Assert.That(() => new SentryIPService(invalidDataInput, invalidExponent), Throws.ArgumentException.And.Message.EqualTo("Invalid parameters must be int"));
		}
	}
}