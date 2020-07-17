namespace JplApiTesting.ApiObjectModels.CAD.DataHandling
{
	public class CadErrorRoot
	{
		public string moreInfo { get; set; }
		public string message { get; set; }
		public string code { get; set; }

		
		public Signature signature { get; set; }
		public string error { get; set; }
		
		public class Signature
		{
			public string source { get; set; }
			public string version { get; set; }
		}

	}
}