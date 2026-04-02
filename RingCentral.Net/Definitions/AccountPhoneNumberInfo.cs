namespace RingCentral
  {
      public class AccountPhoneNumberInfo
      {
          /// <summary>
        ///     Phone number activation status. Determine whether phone number migration is completed on the partner side.
        ///     Enum: Active, Inactive
        /// </summary>
        public string activationStatus { get; set; }

        /// <summary>
        ///     Internal unique identifier of a phone number
        ///     Required
        ///     Example: 1162820004
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Indicates if a number is toll or toll-free
        ///     Required
        ///     Example: Toll
        ///     Enum: Toll, TollFree
        /// </summary>
        public string tollType { get; set; }

        /// <summary>
        ///     Usage type of a phone number
        ///     Required
        ///     Enum: MainCompanyNumber, DirectNumber, Inventory, InventoryPartnerBusinessMobileNumber, InventoryFmcBusinessMobileNumber, PartnerBusinessMobileNumber, AdditionalCompanyNumber, CompanyNumber, PhoneLine, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberStorage, BusinessMobileNumber, FmcBusinessMobileNumber, ELIN, InventoryMobileNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        /// </summary>
        public bool? byocNumber { get; set; }

        /// <summary>
        /// </summary>
        public bool? mobileNumber { get; set; }

        /// <summary>
        ///     Indicates whether the phone number belongs to a Hot Desk device if applicable.
        /// </summary>
        public bool? hotDeskNumber { get; set; }

        /// <summary>
        /// </summary>
        public ContactCenterProvider contactCenterProvider { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is `Normal`, the phone
            ///     number is ready to be used. Otherwise, it is an external number not yet
            ///     ported to RingCentral
        ///     Required
        ///     Enum: Normal, Pending, PortedIn, Temporary, Unknown
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Caller ID Name
        /// </summary>
        public string callerIdName { get; set; }

        /// <summary>
        ///     Reference to the extension this number is assigned to. Omitted for company numbers
        /// </summary>
        public AccountPhoneNumberInfoExtension extension { get; set; }

        /// <summary>
        ///     Internal identifier of a phone provider
        /// </summary>
        public string providerId { get; set; }
      }
  }