namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCloudConnectorForwardingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CloudConnectorRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }
    }
}