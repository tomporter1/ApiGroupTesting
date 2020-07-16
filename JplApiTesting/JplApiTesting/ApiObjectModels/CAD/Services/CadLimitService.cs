using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadLimitService : CadService
    {
        public CadLimitService(int limit)
        {
            if (limit < 0)
                throw new ArgumentException("The limit for the request cannot be negative");

            ResponseData = callManager.GetLimitData(limit);

            Setup();
        }
    }
}