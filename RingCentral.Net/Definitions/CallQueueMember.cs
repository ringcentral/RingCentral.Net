namespace RingCentral
  {
    /// <summary>
/// Call queue member information
/// </summary>
      public class CallQueueMember
      {
          /// <summary>
        ///     Internal identifier of an extension - queue member
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension full name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public SiteBasicInfo site { get; set; }

        /// <summary>
        ///     Extension subtype, if applicable.
            ///     For unrecognized subtypes the `Unknown` value is returned
        ///     Enum: VideoPro, VideoProPlus, DigitalSignageOnlyRooms, Unknown, Emergency
        /// </summary>
        public string extensionSubType { get; set; }
      }
  }