using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadLimitService : CADService
    {
        public CadLimitService(int limit)
        {
            if (limit < 0)
                throw new ArgumentException("The limit for the request cannot be negative");

            liveCurrent = callManager.GetLimitData(limit);

            Setup();
        }
    }
}