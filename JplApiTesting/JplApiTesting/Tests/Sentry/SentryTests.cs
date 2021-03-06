﻿using System;
using JplApiTesting.ApiObjectModels.Sentry.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Sentry
{
	public class SentryTests
	{
		//obtain summary data for all available Sentry objects
		private SentrySummaryDataService sentryService;

		private int countGivenInAPI;

		[OneTimeSetUp]
		public void Setup()
		{
			sentryService = new SentrySummaryDataService();
		}

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
		public void CountField_ReturnsCorrectAmount()
		{
			countGivenInAPI = Int32.Parse(sentryService.dto.LatestSentry.count);
			Assert.That(sentryService.dto.LatestSentry.data.Count, Is.EqualTo(countGivenInAPI));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureSource_ReturnsCorrectSource()
		{
			Assert.That(sentryService.dto.LatestSentry.signature.source.ToString(), Is.EqualTo("NASA/JPL Sentry Data API"));
		}

		[Test]
		[Author("N Sahota")]
		public void FileSignatureVersion_ReturnsCorrectVersion()
		{
			Assert.That(sentryService.dto.LatestSentry.signature.version.ToString(), Is.EqualTo("1.1"));
		}

		[Test]
		[Author("N Sahota")]
		public void OldestAsteroidDataFullname_Returns_FullnameOfAsteroid()
		{
			Assert.That(sentryService.dto.LatestSentry.data[0].fullname.ToString(), Is.EqualTo("(1979 XB)"));
		}

		[Test]
		[Author("N Sahota")]
		public void OldestObservation_ReturnsCorrectDate()
		{
			Assert.That(sentryService.dto.LatestSentry.data[0].last_obs.ToString(), Is.EqualTo("1979-Dec-15.42951"));
		}

		[Test]
		[Author("N Sahota")]
		public void CompareDateToCurrent_APIDate_ReturnsStateOfDate()
		{
			//SummarySentryAPI only holds current/past data, not future
			countGivenInAPI = int.Parse(sentryService.dto.LatestSentry.count) - 1;
			string latestdate = sentryService.dto.LatestSentry.data[countGivenInAPI].last_obs;

			DateTime formatDate = sentryService.CovertAPIDate(latestdate);
			Assert.That(sentryService.CompareDateToCurrent(formatDate), Is.EqualTo("API Date is before current."));
		}
	}
}