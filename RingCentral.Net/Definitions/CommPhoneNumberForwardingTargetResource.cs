namespace RingCentral
  {
      public class CommPhoneNumberForwardingTargetResource
      {
          /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: PhoneNumberRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
      }
  }