namespace RingCentral
{
    public class ServiceFeatureValue
    {
        /// <summary>
        /// </summary>
        public string featureName { get; set; }

        /// <summary>
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Enum: Available, AccountTypeLimitation, ExtensionTypeLimitation, AccountLimitation, ExtensionLimitation,
        ///     InsufficientPermissions, ApplicationLimitation
        /// </summary>
        public string reason { get; set; }
    }
}