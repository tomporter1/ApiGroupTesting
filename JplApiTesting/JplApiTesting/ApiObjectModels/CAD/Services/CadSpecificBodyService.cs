using System;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
	public class CadSpecificBodyService : CADService
	{
		public CadSpecificBodyService(string body)
		{
			if (body == string.Empty)
				throw new ArgumentException("The body cannot be an empty string");

			liveCurrent = callManager.GetSpecificBodyData(body);

			Setup();
		}
	}
}