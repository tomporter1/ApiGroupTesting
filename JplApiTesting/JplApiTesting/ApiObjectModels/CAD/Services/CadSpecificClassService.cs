using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadSpecificClassService : CadService
    {
        public CadSpecificClassService(string specificClass)
        {
            if (specificClass == string.Empty)
                throw new ArgumentException("The class cannot be an empty string");

            ResponceData = callManager.GetSpecificClassData(specificClass);

            Setup();
        }
    }
}