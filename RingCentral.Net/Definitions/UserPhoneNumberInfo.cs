namespace RingCentral
{
    public class UserPhoneNumberInfo
    {
        /// <summary>
        ///     Link to the user's phone number resource
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
        public ContactCenterProvider contactCenterProvider { get; set; }

        /// <summary>
        /// </summary>
        public UserPhoneNumberExtensionInfo extension { get; set; }

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
        ///     Specifies if the number is primary, i.e. displayed as 'main number' and called by default
        /// </summary>
        public bool? primary { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an
        ///     external number not yet ported to RingCentral
        ///     Enum: Normal, Pending, PortedIn, Temporary
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Phone number type
        ///     Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Extension sub-type, if applicable. For any unsupported sub-types the 'Unknown' value will be returned
        ///     Enum: VideoPro, VideoProPlus, DigitalSignage, Unknown
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        ///     Usage type of a phone number. Numbers of 'NumberPool' type will not be returned for phone number list requests
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, NumberPool, BusinessMobileNumber,
        ///     IntegrationNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        ///     List of features of a phone number
        ///     Enum: CallerId, SmsSender, A2PSmsSender, MmsSender, InternationalSmsSender, Delegated
        /// </summary>
        public string[] features { get; set; }
    }
}