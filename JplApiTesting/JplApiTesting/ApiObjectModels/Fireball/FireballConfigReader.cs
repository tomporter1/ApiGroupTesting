namespace JplApiTesting.ApiObjectModels.Fireball
{
    public class FireballConfigReader : ConfigReader
    {
        public static readonly string BaseUrl = configObj.Fireball.url;

        public static readonly string MinDate = configObj.Fireball.parameters.minDate;
        public static readonly string MaxDate = configObj.Fireball.parameters.maxDate;

        public static readonly string MinEnergy = configObj.Fireball.parameters.minEnergy;
        public static readonly string MaxEnergy = configObj.Fireball.parameters.maxEnergy;

        public static readonly string MinVelocity = configObj.Fireball.parameters.minVelocity;
        public static readonly string MaxVelocity = configObj.Fireball.parameters.maxVelocity;

        public static readonly string LocationRequired = configObj.Fireball.parameters.locationRequired;
        public static readonly string AltitudeRequired = configObj.Fireball.parameters.altitudeRequired;

        public static readonly string VelocityComponentsRequired = configObj.Fireball.parameters.velocityComponentsRequired;
        public static readonly string VelocityComponents = configObj.Fireball.parameters.velocityComponents;

        public static readonly string Sort = configObj.Fireball.parameters.sort;

        public static readonly string Limit = configObj.Fireball.parameters.limit;
    }
}