namespace RingCentral
{
    /// <summary>
    ///     Ring target
    /// </summary>
    public class CommCoworkerForwardingTargetResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }

        /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CoworkerRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget,
        ///     IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }
    }
}