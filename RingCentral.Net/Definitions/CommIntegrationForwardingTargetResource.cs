namespace RingCentral
  {
      public class CommIntegrationForwardingTargetResource
      {
          /// <summary>
        ///     Ring target type
        ///     Required
        ///     Example: IntegrationRingTarget
        ///     Enum: CoworkerAppsRingTarget, CoworkerRingTarget, DeviceRingTarget, ImsPhoneNumberRingTarget, FmcPhoneNumberRingTarget, IntegrationRingTarget, PhoneNumberRingTarget
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CommIntegrationResource integration { get; set; }
      }
  }