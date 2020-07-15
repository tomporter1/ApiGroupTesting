using JplApiTesting.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Fireball
{
	[TestFixture]
	[Author("K McEvaddy")]
	public class FireballApiGeneralShould
	{
		private const int ExpectedNumFields = 9;
		protected FireballService _fireballService = null;

		[SetUp]
		[Author("K McEvaddy")]
		public virtual void Setup()
		{
			_fireballService = new FireballService();
		}

		[Test]
		[Author("K McEvaddy")]
		public void Contains_CorrectNumberOfFields()
		{
			Assert.That(_fireballService.GetFields().Count, Is.EqualTo(ExpectedNumFields));
		}

		[Test]
		[Author("K McEvaddy")]
		public void Contains_APopulatedListOfFields()
		{
			Assert.That(_fireballService.GetFields(), Is.Not.Empty);
		}

		// Assert that "data" contains "count" number of elements
		[Test]
		[Author("K McEvaddy")]
		public void EachDatumContains_CountElements()
		{
			Assert.Fail();
		}

		// Assert that "signature".source == "NASA/JPL Fireball Data API"

		// Assert that "data"[TEST_CASE_INT]."date" is a valid date

		// Assert that "data"[TEST_CASE_INT]."date" is a valid time

		// Assert that "data"[TEST_CASE_INT]."lat-dir" is "N" or "S"

		// Assert that "data"[TEST_CASE_INT]."lon-dir" is "E" or "W"
	}
}