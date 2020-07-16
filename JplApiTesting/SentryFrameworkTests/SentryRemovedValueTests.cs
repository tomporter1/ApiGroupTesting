using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryRemovedValueTests
	{
		private SentryRemovedService sentryRemovedService;

		[TestCase("Y")]
		[TestCase("true")]
		[TestCase("1")]
		[Author("N Sahota")]
		public void CountNumImpactsRemoved_ReturnsCountOfRemovedMeteors(string showRemoved)
		{
			sentryRemovedService = new SentryRemovedService(showRemoved);

			string countGivenInAPI = sentryRemovedService.dto.SentryRemoved.count;
			Assert.That(sentryRemovedService.dto.SentryRemoved.data.Count.ToString(), Is.EqualTo(countGivenInAPI));
		}

		[TestCase("N")]
		[TestCase("false")]
		[TestCase("0")]
		[Author("N Sahota")]
		public void CountNumImpacts_ReturnsCountOfMeteors(string showRemoved)
		{
			sentryRemovedService = new SentryRemovedService(showRemoved);

			string countGivenInAPI = sentryRemovedService.dto.SentryRemoved.count;
			Assert.That(sentryRemovedService.dto.SentryRemoved.data.Count.ToString(), Is.EqualTo(countGivenInAPI));
		}
	}
}
