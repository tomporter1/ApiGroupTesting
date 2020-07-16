using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    public class CadAllDataService : CadService
    {
        public CadAllDataService()
        {
            Dictionary<RequestParametersTypes, RequestParameterInfo> requestParams = new Dictionary<RequestParametersTypes, RequestParameterInfo>()
            {
                [RequestParametersTypes.Body] = new RequestParameterInfo() { Label = CADConfigReader.BodyParam, Data = "All" }
            };

            ResponseData = callManager.MakeRequest(requestParams);

            Setup();
        }
    }
}