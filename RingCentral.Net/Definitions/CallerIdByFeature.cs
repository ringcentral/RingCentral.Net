namespace RingCentral
  {
    /// <summary>
/// Caller ID settings by feature
/// </summary>
      public class CallerIdByFeature
      {
          /// <summary>
        ///     Enum: RingOut, RingMe, CallFlip, FaxNumber, AdditionalSoftphone, Alternate, CommonPhone, MobileApp, Delegated, BusinessMobile
        /// </summary>
        public string feature { get; set; }

        /// <summary>
        /// </summary>
        public CallerIdData callerId { get; set; }
      }
  }