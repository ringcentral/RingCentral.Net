namespace RingCentral
{
    public class CommIntegrationTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommIntegrationResource integration { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: IntegrationRingTarget
        ///     Enum: IntegrationRingTarget
        /// </summary>
        public string type { get; set; }
    }
}