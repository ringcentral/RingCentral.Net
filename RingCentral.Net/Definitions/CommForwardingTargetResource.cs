namespace RingCentral
{
    public class CommForwardingTargetResource
    {
        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget, CloudConnectorRingTarget
        /// </summary>
        public string type { get; set; }
    }
}