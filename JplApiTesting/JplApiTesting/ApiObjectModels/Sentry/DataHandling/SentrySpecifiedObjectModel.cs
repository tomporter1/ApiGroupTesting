using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{

	public class SentrySpecifiedRoot
	{
		public Summary summary { get; set; }
		public Signature signature { get; set; }
		public List<Datum> data { get; set; }
	}

	public class Summary
	{
		public string energy { get; set; }
		public string darc { get; set; }
		public string ip { get; set; }
		public string h { get; set; }
		public string nobs { get; set; }
		public string mass { get; set; }
		public string v_inf { get; set; }
		public string first_obs { get; set; }
		public string method { get; set; }
		public string pdate { get; set; }
		public string ndop { get; set; }
		public string cdate { get; set; }
		public string ps_cum { get; set; }
		public string diameter { get; set; }
		public string ndel { get; set; }
		public string v_imp { get; set; }
		public string ps_max { get; set; }
		public string last_obs { get; set; }
		public string fullname { get; set; }
		public string n_imp { get; set; }
		public string ts_max { get; set; }
		public string nsat { get; set; }
		public string des { get; set; }
	}
}
