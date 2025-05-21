namespace RingCentral
{
    public class CommRingGroupActionRequestTargets
    {
        /// <summary>
        ///     Ring target type
        ///     Example: PhoneNumberRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget,
        ///     ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        /// </summary>
        public CommDeviceRequest device { get; set; }

        /// <summary>
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationRequest integration { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}