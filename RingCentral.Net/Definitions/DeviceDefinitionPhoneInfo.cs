namespace RingCentral
  {
      public class DeviceDefinitionPhoneInfo
      {
          /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Example: Toll
        ///     Enum: Toll, TollFree
        /// </summary>
        public string tollType { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Preferred area code to use if the numbers are available
        ///     Example: 650
        /// </summary>
        public string preferredAreaCode { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Phone number reservation ID. If provided, phoneNumber is also required
        /// </summary>
        public string reservationId { get; set; }

        /// <summary>
        ///     Phone number identifier
        /// </summary>
        public string phoneNumberId { get; set; }
      }
  }