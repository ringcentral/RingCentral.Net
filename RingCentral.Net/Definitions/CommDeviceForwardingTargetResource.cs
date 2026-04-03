namespace RingCentral
{
    public class CommDeviceForwardingTargetResource
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: DeviceRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommDeviceResource device { get; set; }

        /// <summary>
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Device name
        ///     Example: HP2
        /// </summary>
        public string name { get; set; }
    }
}