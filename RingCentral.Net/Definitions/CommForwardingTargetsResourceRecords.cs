namespace RingCentral
{
    public class CommForwardingTargetsResourceRecords
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Example: PhoneNumberRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget,
        ///     IntegrationRingTarget, PhoneNumberRingTarget
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
        public CommPhoneNumberResource destination { get; set; }

        /// <summary>
        /// </summary>
        public CommIntegrationResource integration { get; set; }
    }
}