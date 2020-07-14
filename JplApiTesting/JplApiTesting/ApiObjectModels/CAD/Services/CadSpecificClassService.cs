using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadSpecificClassService : CADService
    {
        public CadSpecificClassService(string specificClass)
        {
            if (specificClass == string.Empty)
                throw new ArgumentException("The class cannot be an empty string");

            liveCurrent = callManager.GetSpecificClassData(specificClass);

            Setup();
        }
    }
}