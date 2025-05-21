namespace RingCentral
{
    public class CommIntegrationRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: IntegrationRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommIntegrationRequest integration { get; set; }
    }
}