namespace RingCentral
{
    public class CommIntegrationForwardingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: IntegrationRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget,
        ///     IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommIntegrationResource integration { get; set; }
    }
}