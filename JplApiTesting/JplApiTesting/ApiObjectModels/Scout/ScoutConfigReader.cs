namespace JplApiTesting.ApiObjectModels
{
	public class ScoutConfigReader : ConfigReader
	{
		public static readonly string ScoutUrl = configObj.Scout.url;
		public static readonly string TdesParam = configObj.Scout.parameters.tdes;
		public static readonly string DateParam = configObj.Scout.parameters.date;
	}
}