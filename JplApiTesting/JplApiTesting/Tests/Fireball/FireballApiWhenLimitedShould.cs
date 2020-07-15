using JplApiTesting.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Fireball
{
	[TestFixture]
	[Author("K McEvaddy")]
	public class FireballApiWhenLimitedShould : FireballApiShould
	{
		public const int Count = 10;

		[SetUp]
		[Author("K McEvaddy")]
		public override void Setup()
		{
			_fireballService = new FireballService(Count);
		}

		[TestCase(Count)]
		[Author("K McEvaddy")]
		public override void ApiCall_Count_ReturnsValidCount(in int expectedCount)
		{
			base.ApiCall_Count_ReturnsValidCount(expectedCount);
		}
	}
}