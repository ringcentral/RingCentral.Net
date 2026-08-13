namespace RingCentral
{
    public class CommRingAlwaysGroupActionRequestTargets
    {
        /// <summary>
        ///     Ring target type
        ///     Example: AllMobileRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}