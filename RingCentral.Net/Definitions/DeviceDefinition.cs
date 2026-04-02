namespace RingCentral
  {
      public class DeviceDefinition
      {
          /// <summary>
        ///     Device type. Only "OtherPhone" and "WebRTC" device types are supported at the moment
        ///     Required
        ///     Enum: OtherPhone, WebRTC
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public DeviceDefinitionEmergency emergency { get; set; }

        /// <summary>
        ///     Assign a specific phone number
        ///     Required
        /// </summary>
        public DeviceDefinitionPhoneInfo phoneInfo { get; set; }

        /// <summary>
        ///     The option that indicates whether Contact Center Phone Line should be created or not
        /// </summary>
        public bool? contactCenterPhoneLine { get; set; }
      }
  }