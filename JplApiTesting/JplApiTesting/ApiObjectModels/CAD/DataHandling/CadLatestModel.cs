﻿using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.DataHandling
{
    public class CadLatestRoot
    {
        public Signature signature { get; set; }
        public string count { get; set; }
        public List<string> fields { get; set; }
        public List<List<string>> data { get; set; }
    }

    public class Signature
    {
        public string source { get; set; }
        public string version { get; set; }
    }
}