namespace RingCentral
{
    /// <summary>
    /// Ring target
    /// </summary>
    public class CommCoworkerRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CoworkerRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}