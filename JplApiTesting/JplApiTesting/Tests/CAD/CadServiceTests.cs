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
            Assert.That(() => new CadCustomRequestService(""), Throws.ArgumentException.And.Message.EqualTo("The request cannot be an empty string"));
        }
    }
}