namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CloudConnectorTargetRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Type of a ring target
        ///     Example: CloudConnectorRingTarget
        ///     Enum: CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }
    }
}