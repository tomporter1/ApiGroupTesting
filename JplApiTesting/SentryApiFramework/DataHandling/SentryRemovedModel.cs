using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{

	public class SentryRemovedRoot
	{
		public string count { get; set; }
		public Signature signature { get; set; }
		public List<RemovedDatum> data { get; set; }
	}

	public class RemovedDatum
	{
		public string removed { get; set; }
		public string des { get; set; }
	}

}
