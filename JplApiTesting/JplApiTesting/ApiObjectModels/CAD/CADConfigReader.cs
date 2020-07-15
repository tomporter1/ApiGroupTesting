namespace JplApiTesting.ApiObjectModels.CAD
{
	public class CADConfigReader : ConfigReader
	{
		public static readonly string BaseUrl = _configObj.CAD.url;
		public static readonly string BodyParam = _configObj.CAD.parameters.body;
		public static readonly string LimitParam = _configObj.CAD.parameters.limit;
		public static readonly string ClassParam = _configObj.CAD.parameters._class;
		public static readonly string MinDateParam = _configObj.CAD.parameters.minDate;
		public static readonly string MaxDateParam = _configObj.CAD.parameters.maxDate;
	}
}