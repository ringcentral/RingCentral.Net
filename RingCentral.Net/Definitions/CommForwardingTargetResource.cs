namespace RingCentral
{
    public class CommForwardingTargetResource
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget,
        ///     IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }
    }
}