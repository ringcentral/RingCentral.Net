namespace RingCentral
{
    public class CommRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}