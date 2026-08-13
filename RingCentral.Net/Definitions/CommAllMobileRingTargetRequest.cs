namespace RingCentral
{
    /// <summary>
    /// All Mobile Ring target
    /// </summary>
    public class CommAllMobileRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: AllMobileRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}