using JplApiTesting.ApiObjectModels;
using JplApiTesting.ApiObjectModels.CAD;
using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace JplApiTesting.Tests.CAD
{
    public class CadServiceTests
    {
        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyStringBody()
        {
            Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
            {
                [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "" }
            };

            Assert.That(() => new CadSpecificBodyService(requestParams), Throws.ArgumentException.And.Message.EqualTo("The body cannot be an empty string"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyStringClass()
        {
            Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
            {
                [RequestParametersTypes.Class] = new RequestParameterInfo() { Label = CADConfigReader.ClassParam, Data = "" }
            };

            Assert.That(() => new CadSpecificClassService(requestParams), Throws.ArgumentException.And.Message.EqualTo("The class cannot be an empty string"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithNegativeLimit()
        {
            Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
            {
                [RequestParametersTypes.Limit] = new RequestParameterInfo() { Label = CADConfigReader.LimitParam, Data = "-1" }
            };

            Assert.That(() => new CadLimitService(requestParams), Throws.ArgumentException.And.Message.EqualTo("The limit for the request cannot be negative"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyRequestString()
        {
            Assert.That(() => new CadErrorRespService(new Dictionary<RequestParametersTypes, RequestParameterInfo>()), Throws.ArgumentException.And.Message.EqualTo("The request cannot be an empty string"));
        }

        [TestCase("2020-07-32", "2020-08-01", "The minimum date must be valid and in the form YYYY-MM-DD")]
        [TestCase("2020-07-01", "2020-08-33", "The maximum date must be valid and in the form YYYY-MM-DD")]
        [TestCase("2020-07-01", "", "The date cannot be an empty string")]
        [TestCase("", "2020-08-01", "The date cannot be an empty string")]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithInvalidMinDate(string minDate, string maxDate, string expectedMsg)
        {
            Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
            {
                [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" },
                [RequestParametersTypes.MinDate] = new RequestParameterInfo() { Label = CADConfigReader.MinDateParam, Data = minDate },
                [RequestParametersTypes.MaxDate] = new RequestParameterInfo() { Label = CADConfigReader.MaxDateParam, Data = maxDate }
            };

            Assert.That(() => new CadDateFilteredService(requestParams), Throws.ArgumentException.And.Message.EqualTo(expectedMsg));
        }
    }
}