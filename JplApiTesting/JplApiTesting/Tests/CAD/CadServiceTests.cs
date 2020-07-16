using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
    public class CadServiceTests
    {
        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyStringBody()
        {
            Assert.That(() => new CadSpecificBodyService(""), Throws.ArgumentException.And.Message.EqualTo("The body cannot be an empty string"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyStringClass()
        {
            Assert.That(() => new CadSpecificClassService(""), Throws.ArgumentException.And.Message.EqualTo("The class cannot be an empty string"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithNegativeLimit()
        {
            Assert.That(() => new CadLimitService(-1), Throws.ArgumentException.And.Message.EqualTo("The limit for the request cannot be negative"));
        }

        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyRequestString()
        {
            Assert.That(() => new CadErrorRespService(""), Throws.ArgumentException.And.Message.EqualTo("The request cannot be an empty string"));
        }

        [TestCase("2020-07-32", "2020-08-01", "The minimum date must be valid and in the form YYYY-MM-DD")]
        [TestCase("2020-07-01", "2020-08-33", "The maximum date must be valid and in the form YYYY-MM-DD")]
        [TestCase("2020-07-01", "", "The date cannot be an empty string")]
        [TestCase("", "2020-08-01", "The date cannot be an empty string")]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithInvalidMinDate(string minDate, string maxDate, string expectedMsg)
        {
            Assert.That(() => new CadDateFilteredService(minDate, maxDate), Throws.ArgumentException.And.Message.EqualTo(expectedMsg));
        }
    }
}