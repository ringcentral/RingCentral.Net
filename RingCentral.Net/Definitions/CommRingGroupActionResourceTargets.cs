namespace RingCentral
{
    public class CommRingGroupActionResourceTargets
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: CloudConnectorRingTarget
        ///     Enum: AllDesktopRingTarget, AllMobileRingTarget, CoworkerRingTarget, DeviceRingTarget, HotdeskRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        /// </summary>
        public CommDeviceResource device { get; set; }

        /// <summary>
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationResource integration { get; set; }
    }
}