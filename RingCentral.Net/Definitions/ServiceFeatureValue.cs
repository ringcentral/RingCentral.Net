namespace RingCentral
{
    public class ServiceFeatureValue
    {
        public string featureName;

        public bool? enabled;

        // Enum: Available, AccountTypeLimitation, ExtensionTypeLimitation, AccountLimitation, ExtensionLimitation, InsufficientPermissions, ApplicationLimitation
        public string reason;
    }
}