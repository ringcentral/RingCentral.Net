namespace RingCentral
{
    /// <summary>
    ///     All Mobile Ring target
    /// </summary>
    public class CommAllMobileRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: AllMobileRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}