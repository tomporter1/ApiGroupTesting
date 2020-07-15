using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryObjectTests
	{
		private SentryService sentryService = new SentryService("99942");

		[Test]
		public void CountField_ReturnsCorrectAmount()
		{
			//Assert.That(sentryService.dto.LatestSentry., Is.EqualTo("1"));
		}
	}
}
