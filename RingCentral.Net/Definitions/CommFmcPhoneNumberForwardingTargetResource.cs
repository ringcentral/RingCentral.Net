namespace RingCentral
  {
      public class CommFmcPhoneNumberForwardingTargetResource
      {
          /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: FmcPhoneNumberRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
      }
  }