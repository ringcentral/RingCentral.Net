namespace RingCentral
{
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