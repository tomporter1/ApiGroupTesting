namespace JplApiTesting.ApiObjectModels
{
    public class ConfigRoot
    {
        public Info CAD { get; set; }
        public Info Fireball { get; set; }

        public Info Scout { get; set; }

        public Info Sentry { get; set; }

    }

    public class Info
    {     
        public string url { get; set; }
    }
}