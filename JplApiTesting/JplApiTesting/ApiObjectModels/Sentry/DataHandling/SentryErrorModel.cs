﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JplApiTesting.ApiObjectModels.Sentry.DataHandling
{
	public class SentryErrorRoot
	{
		public string moreInfo { get; set; }
		public string message { get; set; }
		public string code { get; set; }
	}

}