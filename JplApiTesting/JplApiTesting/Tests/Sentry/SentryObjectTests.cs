using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryObjectTests
	{
		//obtain details related to a specified Sentry object
		private SentryService sentryService = new SentryService("99942");

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
		public void CheckFullName_ReturnsCorrectName()
		{
			Assert.That(sentryService.dto.specifiedSentry.summary.fullname.ToString(),
				Is.EqualTo("99942 Apophis (2004 MN4)"));
		}

		[Test]
		[Author("N Sahota")]
		public void MassIsOverZero_MeteorMass_ReturnsTrue()
		{
			string mass = sentryService.dto.specifiedSentry.summary.mass.ToString();
			Assert.That(sentryService.CheckMassIsOverZeroSpecifiedObject(mass), Is.True);
		}

		[Test]
		[Author("N Sahota")]
		public void CountNumPotentialMeteorImpacts_ReturnsCountOfPredictedStrikes()
		{
			Assert.That(sentryService.dto.specifiedSentry.data.Count, Is.EqualTo(12));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureSource_ReturnsCorrectSource()
		{
			Assert.That(sentryService.dto.specifiedSentry.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureVersion_ReturnsCorrectVersion()
		{
			Assert.That(sentryService.dto.specifiedSentry.signature.version.ToString(), Is.EqualTo("1.1"));
		}

		[Test]
		[Author("N Sahota")]
		public void ComparePredictedImpactDates_ReturnFalseIfDiffrent()
		{
			//Output should be false according to the API doc, A potential impact cannot be the same for one meteor
			string firstDate = sentryService.dto.specifiedSentry.data[0].date;
			string secondDate = sentryService.dto.specifiedSentry.data[1].date;

			Assert.That(sentryService.CompareDatesSpecifiedObject(firstDate, secondDate), Is.False);
		}

		[Test]
		[Author("N Sahota")]
		public void ValidateEnergyData_SpecificImpactData_ReturnsCorretValue()
		{
			Assert.That(sentryService.dto.specifiedSentry.data[6].energy.ToString(), Is.EqualTo("1.151e+03"));
		}

		[Test]
		[Author("N Sahota")]
		public void ValidateIPData_SpecificImpactData_ReturnsCorretValue()
		{
			//ip = The cumulative probability that the tabulated impact will occur, where 0 is no impact
			Assert.That(sentryService.dto.specifiedSentry.data[6].ip.ToString(), Is.EqualTo("6.7e-06"));
		}
	}
}