using JplApiTesting.ApiObjectModels;
using JplApiTesting.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Fireball
{
	[TestFixture]
	[Author("K McEvaddy")]
	public class FireballApiShould
	{
		public const int CurrentApproximateCount = 800;
		protected FireballService _fireballService = null;

		[SetUp]
		[Author("K McEvaddy")]
		public virtual void Setup()
		{
			_fireballService = new FireballService();
		}

		[Test]
		[Author("K McEvaddy")]
		public void Config_Url_ReturnsApiWebsite()
		{
			Assert.That(
				FireballConfigReader.BaseUrl,
				Is.EqualTo("https://ssd-api.jpl.nasa.gov/fireball.api"));
		}

		[TestCase(CurrentApproximateCount)]
		[Author("K McEvaddy")]
		public virtual void ApiCall_Count_ReturnsValidCount(in int expectedCount)
		{
			// Arrange, Act
			int response = _fireballService.GetCount();
			// Assert
			Assert.That(response, Is.GreaterThan(expectedCount));
		}
	}
}