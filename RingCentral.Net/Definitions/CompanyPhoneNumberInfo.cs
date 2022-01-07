namespace RingCentral
{
    public class CompanyPhoneNumberInfo
    {
        /// <summary>
        ///     Link to a company phone number resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a phone number
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// </summary>
        public CountryInfo country { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionInfo extension { get; set; }

        /// <summary>
        ///     Custom user name of a phone number, if any
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Location (City, State). Filled for local US numbers
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        ///     Enum: External, TollFree, Local, BusinessMobileNumberProvider, ExternalNumberProvider
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an
        ///     external number not yet ported to RingCentral
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Phone number type
        ///     Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Usage type of a phone number. Usage type of a phone number. Numbers of 'NumberPool' type wont't be returned for
        ///     phone number list requests
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, MeetingsNumber, NumberPool, BusinessMobileNumber,
        ///     IntegrationNumber
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
        ///     request parameters nxx plus line or numberPattern
        /// </summary>
        public string vanityPattern { get; set; }
    }
}