namespace RingCentral
{
    /// <summary>
    ///     Reason for the feature unavailability. Returned only if `available`
    ///     is set to `false`
    /// </summary>
    public class ReasonInfo
    {
        /// <summary>
        ///     Reason code
        ///     Enum: ServicePlanLimitation, AccountLimitation, ExtensionTypeLimitation, ExtensionLimitation,
        ///     InsufficientPermissions, ConfigurationLimitation
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     Reason description
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// </summary>
        public string permission { get; set; }
    }
}