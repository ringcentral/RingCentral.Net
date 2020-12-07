namespace RingCentral
{
    // Reason of the feature unavailability. Returned only if `available` is set to 'false'
    public class ReasonInfo
    {
        /// <summary>
        /// Reason code
        /// Enum: ServicePlanLimitation, AccountLimitation, ExtensionTypeLimitation, ExtensionLimitation, InsufficientPermissions, ConfigurationLimitation
        /// </summary>
        public string code;

        /// <summary>
        /// Reason description
        /// </summary>
        public string message;

        /// <summary>
        /// </summary>
        public string permission;
    }
}