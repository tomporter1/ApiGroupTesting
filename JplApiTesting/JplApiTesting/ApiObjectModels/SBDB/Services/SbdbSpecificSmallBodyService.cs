using System;

namespace JplApiTesting.ApiObjectModels.SBDB.Services
{
    public class SbdbSpecificSmallBodyService : SbdbService
    {
        public SbdbSpecificSmallBodyService(string bodyName)
        {
            if (bodyName == string.Empty)
                throw new ArgumentException("The body cannot be an empty string");

            ResponseData = callManager.GetSpecificBodyData(bodyName);

            SetUp();
        }
    }
}