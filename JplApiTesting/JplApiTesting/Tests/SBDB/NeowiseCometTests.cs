using JplApiTesting.ApiObjectModels.CAD.Services;
using JplApiTesting.ApiObjectModels.SBDB.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.Tests.SBDB
{
    public class NeowiseCometTests
    {
        private SbdbSpecificSmallBodyService _cadService;
        private readonly string _bodyName = "2020 F3";

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _cadService = new SbdbSpecificSmallBodyService(_bodyName);
        }

        [Test]
        [Author("T Porter")]
        public void CallingTheAPI_ReturnsCorrectComet()
        {
            Assert.That(_cadService.DTO.SbdbInfo._object.fullname, Is.EqualTo("C/2020 F3 (NEOWISE)"));
        }
    }
}