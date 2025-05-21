namespace RingCentral
{
    public class CommRingAlwaysGroupActionRequestTargets
    {
        /// <summary>
        ///     Ring target type
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