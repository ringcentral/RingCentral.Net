namespace RingCentral
{
    public class CommHotdeskRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: HotdeskRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}