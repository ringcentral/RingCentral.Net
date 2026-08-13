namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCloudConnectorTargetRequest
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

        /// <summary>
        ///     Required
        ///     Example: Cloud Connector Contact
        /// </summary>
        public string name { get; set; }
    }
}