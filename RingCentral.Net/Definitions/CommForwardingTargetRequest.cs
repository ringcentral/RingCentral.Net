namespace RingCentral
{
    public class CommForwardingTargetRequest
    {
        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }
    }
}