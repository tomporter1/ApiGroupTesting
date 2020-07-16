using JplApiTesting.ApiObjectModels.SBDB.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.SBDB
{
    public class SbdbServiceTests
    {
        [Test]
        [Author("T Porter")]
        public void FrameworkThrowsException_WithEmptyStringBody()
        {
            Assert.That(() => new SbdbSpecificSmallBodyService(""), Throws.ArgumentException.And.Message.EqualTo("The body cannot be an empty string"));
        }
    }
}