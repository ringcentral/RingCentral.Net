namespace RingCentral
{
    public class CommImsPhoneNumberRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: ImsPhoneNumberRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
    }
}