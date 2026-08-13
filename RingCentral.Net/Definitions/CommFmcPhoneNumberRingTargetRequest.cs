namespace RingCentral
{
    public class CommFmcPhoneNumberRingTargetRequest
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: FmcPhoneNumberRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
    }
}