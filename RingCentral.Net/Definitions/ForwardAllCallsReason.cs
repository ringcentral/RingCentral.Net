namespace RingCentral
{
    public class ForwardAllCallsReason
    {
        /// <summary>
        ///     Specifies the type of limitation. `ExtensionLimitation` means that the feature is turned off for this particular
        ///     extension.
        ///     `FeatureLimitation` means that the user may enable this feature and setup the rule via the Service Web UI
        ///     Enum: ExtensionLimitation, FeatureLimitation
        /// </summary>
        public string code { get; set; }

        /// <summary>
        ///     Error message depending on the type of limitation
        /// </summary>
        public string message { get; set; }
    }
}