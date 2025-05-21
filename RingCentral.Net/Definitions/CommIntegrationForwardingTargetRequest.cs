namespace RingCentral
{
    public class CommIntegrationForwardingTargetRequest
    {
        /// <summary>
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
        public CommIntegrationRequest integration { get; set; }
    }
}