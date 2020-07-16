using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadSpecificBodyService : CadService
    {
        public CadSpecificBodyService(string body)
        {
            if (body == string.Empty)
                throw new ArgumentException("The body cannot be an empty string");

            ResponseData = callManager.GetSpecificBodyData(body);

            Setup();
        }
    }
}