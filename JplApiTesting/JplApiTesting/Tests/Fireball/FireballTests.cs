using JplApiTesting.ApiObjectModels;
using JplApiTesting.Services;
using NUnit.Framework;

namespace JplApiTesting
{
    [TestFixture]
    public class FireballApi
    {
        public const int CurrentApproximateCount = 800;

        protected FireballService _fireballService = null;

        [SetUp]
        public void Setup()
        {
            _fireballService = new FireballService();
        }
        
        [Test]
        public void UrlIsCorrect()
        {
            Assert.That(
                FireballConfigReader.BaseUrl,
                Is.EqualTo("https://ssd-api.jpl.nasa.gov/fireball.api"));
        }

        [Test]
        public void CountIsValid()
        {
            // Arrange, Act
            int response = _fireballService.GetCount();
            // Assert
            Assert.That(response, Is.GreaterThan(CurrentApproximateCount));
        }
    }
}