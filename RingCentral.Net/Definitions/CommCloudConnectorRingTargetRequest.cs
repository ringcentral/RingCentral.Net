namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCloudConnectorRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CloudConnectorRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Required
        ///     Example: Cloud Connector Contact
        /// </summary>
        public string name { get; set; }
    }
}