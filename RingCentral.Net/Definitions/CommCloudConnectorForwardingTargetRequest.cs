namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCloudConnectorForwardingTargetRequest
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CloudConnectorRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}