namespace RingCentral
{
    public class CompanyPhoneNumberInfo
    {
        /// <summary>
        ///     Link to a company phone number resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a phone number
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// </summary>
        public CountryInfoBasicModel country { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionInfo extension { get; set; }

        /// <summary>
        ///     Custom user-defined name of a phone number, if any
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Location (City, State). Filled for local US numbers
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Payment type. 'External' is returned for forwarded numbers
        ///     which are not terminated in the RingCentral phone system
        ///     Enum: External, TollFree, Local, BusinessMobileNumberProvider, ExternalNumberProvider,
        ///     ExternalNumberProviderTollFree
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is `Normal`, the phone
        ///     number is ready to be used. Otherwise, it is an external number not yet
        ///     ported to RingCentral
        ///     Enum: Normal, Pending, PortedIn, Temporary, Unknown
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Usage type of phone number. Usage type of phone number.
        ///     Numbers of 'NumberPool' type are not returned in phone number list
        ///     requests
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberPool, BusinessMobileNumber,
        ///     PartnerBusinessMobileNumber, IntegrationNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        /// </summary>
        public TemporaryNumberInfo temporaryNumber { get; set; }

        /// <summary>
        /// </summary>
        public ContactCenterProvider contactCenterProvider { get; set; }

        /// <summary>
        ///     Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to
        ///     request parameters `nxx` plus `line` or `numberPattern`
        /// </summary>
        public string vanityPattern { get; set; }

        /// <summary>
        ///     Specifies if a phone number is primary, i.e. displayed as 'main number' and called by default
        /// </summary>
        public bool? primary { get; set; }

        /// <summary>
        ///     Phone number activation status. Determine whether phone number migration is completed on the partner side.
        ///     Enum: Active, Inactive
        /// </summary>
        public string activationStatus { get; set; }
    }
}