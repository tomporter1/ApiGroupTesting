using JplApiTesting.ApiObjectModels.CAD.Services;
using NUnit.Framework;

namespace JplApiTesting.Tests.CAD
{
	public class CadSpecificClassTests
	{
		private CadSpecificClassService _cadService;
		private const string _class = "ATE";
		private const int _expectedNUmOfDataItems = 15;

		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			_cadService = new CadSpecificClassService(_class);
		}

		[Test]
		public void CallingTheAPI_ReturnsCorrectNumberOfDataItems()
		{
			Assert.That(int.Parse(_cadService.dto.LatestCAD.count), Is.EqualTo(_expectedNUmOfDataItems).And.EqualTo(_cadService.dto.LatestCAD.data.Count));
		}
	}
}