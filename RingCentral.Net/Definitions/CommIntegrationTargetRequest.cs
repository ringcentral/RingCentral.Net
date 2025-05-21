namespace RingCentral
{
    public class CommIntegrationTargetRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommIntegrationRequest integration { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: IntegrationRingTarget
        ///     Enum: IntegrationRingTarget
        /// </summary>
        public string type { get; set; }
    }
}