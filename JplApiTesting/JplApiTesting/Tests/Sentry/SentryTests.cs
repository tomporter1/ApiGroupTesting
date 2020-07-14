using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JplApiTesting.ApiObjectModels.Sentry.Services;
using Newtonsoft.Json.Bson;
using JplApiTesting.ApiObjectModels.Sentry;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryTests
	{
		private SentryService sentryService = new SentryService();

		[Test]
		public void CheckCountField_ReturnsAmount()
		{
			Assert.That(sentryService.dto.LatestSentry.count.ToString(), Is.EqualTo("1021"));
		}

	}
}
