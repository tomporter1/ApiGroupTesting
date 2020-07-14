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
		//obtain summary data for all available Sentry objects
		private SentryService sentryService = new SentryService();

		[Test]
		public void CountField_ReturnsCorrectAmount()
		{
			Assert.That(sentryService.dto.LatestSentry.count.ToString(), Is.EqualTo("1021"));
		}

		[Test]
		public void ManualCountDataList_ReturnsCountOfElements()
		{
			Assert.That(sentryService.dto.LatestSentry.data.Count, Is.EqualTo(1021));
		}

		[Test]
		public void FileSignatureSource_ReturnsCorrectSource()
		{
			Assert.That(sentryService.dto.LatestSentry.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
		}

		[Test]
		public void FileSignatureVersion_ReturnsCorrectVersion()
		{
			Assert.That(sentryService.dto.LatestSentry.signature.version.ToString(), Is.EqualTo("1.1"));
		}

		[Test]
		public void FirstAsteroidDataFullname_Returns_FullnameOfAsteroid()
		{
			Assert.That(sentryService.dto.LatestSentry.data[0].fullname.ToString(), Is.EqualTo("(1979 XB)"));
		}

		[Test]
		public void LatestObservation_ReturnsLatest()
		{
			Assert.That(sentryService.dto.LatestSentry.data[1020].last_obs.ToString(), Is.EqualTo("2020-Jun-25.091455"));
		}
		

	}
}
