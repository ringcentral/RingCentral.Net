namespace RingCentral
{
    public class CommForwardingTargetsResourceRecords
    {
        /// <summary>
        ///     Ring target type
        ///     Example: CloudConnectorRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        /// </summary>
        public CommDeviceResource device { get; set; }

        /// <summary>
        ///     Device name
        ///     Example: HP2
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public CommCloudDestination destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationResource integration { get; set; }
    }
}