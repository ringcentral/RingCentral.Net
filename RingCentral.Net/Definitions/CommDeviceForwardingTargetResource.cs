namespace RingCentral
{
    public class CommDeviceForwardingTargetResource
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: DeviceRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget,
        ///     IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommDeviceResource device { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
    }
}