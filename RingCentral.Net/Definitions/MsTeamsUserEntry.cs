namespace RingCentral
  {
      public class MsTeamsUserEntry
      {
          /// <summary>
        ///     RingCentral extension ID of the user to connect
        ///     Required
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }
      }
  }