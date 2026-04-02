namespace RingCentral
  {
      public class AdgPhoneNumberResource
      {
          /// <summary>
        ///     Example: +1 (205) 6812029
        /// </summary>
        public string formattedPhoneNumber { get; set; }

        /// <summary>
        ///     Example: +12056812029
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Example: VoiceFax
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Custom user name of a phone number, if any
        ///     Example: Boss
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Usage type of phone number
        ///     Example: DirectNumber
        ///     Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber, PartnerBusinessMobileNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        ///     Specifies if a phone number should be hidden or not
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        ///     Specifies if the number is primary, i.e. displayed as 'main number' and called by default
        /// </summary>
        public bool? primary { get; set; }

        /// <summary>
        ///     Phone number in E.164 format
        ///     Example: +12056812029
        /// </summary>
        public string e164 { get; set; }

        /// <summary>
        ///     Formatted phone number
        ///     Example: +1 (205) 681-2029
        /// </summary>
        public string formatted { get; set; }

        /// <summary>
        ///     SMS availability status of a phone number
        ///     Enum: Active, Inactive, Disabled, Banned, Suspended, Deprovisioning, InboundOnly, Unknown
        /// </summary>
        public string smsAvailabilityStatus { get; set; }

        /// <summary>
        ///     SMS campaign identifier
        /// </summary>
        public string smsCampaignId { get; set; }
      }
  }