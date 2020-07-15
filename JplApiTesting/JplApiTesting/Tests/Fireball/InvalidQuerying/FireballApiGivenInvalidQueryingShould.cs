using JplApiTesting.ApiObjectModels.Fireball.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.Fireball.InvalidQuerying
{
    [TestFixture]
    [Author("K McEvaddy")]
    public class FireballApiGivenInvalidQueryingShould
    {
        protected FireballService _fireballService = null;
        protected const int NumToQuery = 20;

        [SetUp]
        [Author("K McEvaddy")]
        public virtual void Setup()
        {
            _fireballService = new FireballService(NumToQuery);
        }
    }
}