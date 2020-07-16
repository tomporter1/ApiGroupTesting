using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadGeneralGetService : CadService
    {
        public CadGeneralGetService(Dictionary<RequestParametersTypes, RequestParameterInfo> param)
        {
            ResponseData = callManager.MakeRequest(param);

            Setup();
        }
    }
}