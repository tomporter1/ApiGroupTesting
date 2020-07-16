using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.Fireball.DataHandling
{
    public enum EFields : byte
    {
        date = 0,
        energy,
        impact_e,
        lat,
        lat_dir,
        lon,
        lon_dir,
        alt,
        vel
    }

    public enum ELatitudeDirectionNames : byte
    {
        N = 0,
        S
    }

    public enum ELongitudeDirectionNames : byte
    {
        E = 0,
        W
    }

    public class FireballModel
    {
        public class FireballRoot
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

        // I want to see whether this is worth adding in:
        //public class Datum
        //{
        //    DateTime date  { get; set; }
        //    float energy { get; set; }
        //    float impact_e { get; set; }
        //    float lat { get; set; }
        //    char lat_dir { get; set; }
        //    float lon { get; set; }
        //    char lon_dir { get; set; }
        //    float alt { get; set; }
        //    float vel { get; set; }
        //}
    }
}