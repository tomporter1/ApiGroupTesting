using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Sentry.HTTPManager;
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
		public void CallingAPI_ReturnsCorrectHeaderInfo(string headerKey, string expectedValue)
		{
			Assert.That(sentryService.sentryCallManager.GetContentTypeHeader()[headerKey], Is.EqualTo(expectedValue));
		}

		[Test]
		public void CheckFullName_ReturnsCorrectName()
		{
			Assert.That(sentryService.dto.specifiedSentry.summary.fullname.ToString(),
				Is.EqualTo("99942 Apophis (2004 MN4)"));
		}

		[Test]
		public void MassIsOverZero_MeteorMass_ReturnsTrue()
		{
			string mass = sentryService.dto.specifiedSentry.summary.mass.ToString();
			Assert.That(sentryService.CheckMassIsOverZero(mass), Is.True);
		}

		[Test]
		public void CountNumPotentialMeteorImpacts_ReturnsCountOfPredictedStrikes()
		{
			Assert.That(sentryService.dto.specifiedSentry.data.Count, Is.EqualTo(12));
		}

	}
}
