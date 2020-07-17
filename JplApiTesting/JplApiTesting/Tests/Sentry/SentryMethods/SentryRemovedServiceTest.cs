using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryRemovedServiceTest
	{
		[TestCase("xxgrt")]
		[TestCase("25647")]
		[TestCase(" ")]
		[Author("N Sahota")]
		public void SentryService_GivenInvalidInput_ThrowsArgumentException(string invalidDataInput)
		{
			Assert.That(() => new SentryRemovedService(invalidDataInput), Throws.ArgumentException.And.Message.EqualTo("Argument given in method is invalid must be: Y, 1, true or N, 0, false"));
		}
	}
}