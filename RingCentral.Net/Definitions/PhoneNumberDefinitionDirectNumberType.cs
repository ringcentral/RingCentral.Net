namespace RingCentral
  {
    /// <summary>
/// Assign a specific phone number
/// </summary>
      public class PhoneNumberDefinitionDirectNumberType
      {
          /// <summary>
        ///     Phone number in e164 format
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }
      }
  }