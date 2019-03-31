namespace RingCentral
{
    public class ServiceFeatureValue
    {
        /// <summary>
        /// </summary>
        public string featureName;

        /// <summary>
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Enum: Available, AccountTypeLimitation, ExtensionTypeLimitation, AccountLimitation, ExtensionLimitation, InsufficientPermissions, ApplicationLimitation
        /// </summary>
        public string reason;
    }
}