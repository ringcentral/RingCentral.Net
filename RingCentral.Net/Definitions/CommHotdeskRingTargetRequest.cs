namespace RingCentral
{
    public class CommHotdeskRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: HotdeskRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }
    }
}