using Newtonsoft.Json;
using System;
using System.IO;

namespace JplApiTesting.ApiObjectModels.CAD
{
    public class CADConfigReader : ConfigReader
    {
          public static readonly string BaseUrl = _configObj.CAD.url;
    }
}