namespace RingCentral
  {
      public class CommImsPhoneNumberForwardingTargetResource
      {
          /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: ImsPhoneNumberRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommPhoneNumberResource destination { get; set; }
      }
  }