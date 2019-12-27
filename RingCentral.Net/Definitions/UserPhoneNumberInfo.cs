namespace RingCentral
{
    public class UserPhoneNumberInfo
    {
        /// <summary>
        /// Link to the user's phone number resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        public long? id;

        /// <summary>
        /// Brief information on a phone number country
        /// </summary>
        public CountryInfo country;

        /// <summary>
        /// CCRN (Contact Center Routing Number) provider. If not specified then the default value 'InContact/North America' is used, its ID is '1'
        /// </summary>
        public ContactCenterProvider contactCenterProvider;

        /// <summary>
        /// Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
        /// </summary>
        public UserPhoneNumberExtensionInfo extension;

        /// <summary>
        /// Custom user name of a phone number, if any
        /// </summary>
        public string label;

        /// <summary>
        /// Location (City, State). Filled for local US numbers
        /// </summary>
        public string location;

        /// <summary>
        /// Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// Enum: External, TollFree, Local
        /// </summary>
        public string paymentType;

        /// <summary>
        /// Phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        /// </summary>
        public string status;

        /// <summary>
        /// Phone number type
        /// Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type;

        /// <summary>
        /// Usage type of a phone number. Numbers of 'NumberPool' type wont't be returned for phone number list requests
        /// Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber, NumberPool
        /// </summary>
        public string usageType;

        /// <summary>
        /// List of features of a phone number
        /// </summary>
        public string[] features;
    }
}