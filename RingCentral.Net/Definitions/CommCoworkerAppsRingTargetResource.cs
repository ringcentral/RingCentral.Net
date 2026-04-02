namespace RingCentral
  {
    /// <summary>
/// Coworker apps target
/// </summary>
      public class CommCoworkerAppsRingTargetResource
      {
          /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: CoworkerAppsRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource extension { get; set; }
      }
  }