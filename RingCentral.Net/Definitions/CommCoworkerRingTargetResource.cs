namespace RingCentral
{
    /// <summary>
    ///     Ring target
    /// </summary>
    public class CommCoworkerRingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CoworkerRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}