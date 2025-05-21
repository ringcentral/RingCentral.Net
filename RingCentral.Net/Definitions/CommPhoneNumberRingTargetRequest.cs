namespace RingCentral
{
    public class CommPhoneNumberRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: PhoneNumberRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}