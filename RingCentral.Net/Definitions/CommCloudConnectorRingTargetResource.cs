namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCloudConnectorRingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CloudConnectorRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}