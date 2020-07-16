using RestSharp;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels
{
    public static class TestTools
    {
        internal static Dictionary<string, string> GetContentTypeHeader(IList<Parameter> header)
        {
            // Creating a dictionary and adding all headers and their values
            Dictionary<string, string> HeadersDict = new Dictionary<string, string>();

            foreach (Parameter item in header)
            {
                string[] KeyPairs = item.ToString().Split('=');
                HeadersDict.Add(KeyPairs[0], KeyPairs[1]);
            }
            return HeadersDict;
        }
    }
}