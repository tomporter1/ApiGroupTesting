namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader : ConfigReader
    {
        public static readonly string BaseUrl = configObj.CAD.url;
        public static readonly string BodyParam = configObj.CAD.parameters.body;
        public static readonly string LimitParam = configObj.CAD.parameters.limit;
        public static readonly string ClassParam = configObj.CAD.parameters._class;
        public static readonly string MinDateParam = configObj.CAD.parameters.minDate;
        public static readonly string MaxDateParam = configObj.CAD.parameters.maxDate;
    }
}