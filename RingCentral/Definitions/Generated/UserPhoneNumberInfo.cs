namespace RingCentral
{
    public class UserPhoneNumberInfo : Serializable
    {
        // Internal identifier of a phone number
        public string id;
        // Brief information on a phone number country
        public CountryInfo country;
        // Information on the extension, to which the phone number is assigned. Returned only for the request of Account phone number list
        public ExtensionInfo extension;
        // Custom user name of a phone number, if any. Supported for numbers assigned to Auto-Receptionist, with usage type 'CompanyNumber'
        public string label;
        // Location (City, State). Filled for local US numbers
        public string location;
        // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        // Enum: External, TollFree, Local
        public string paymentType;
        // Phone number
        public string phoneNumber;
        // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        public string status;
        // Phone number type
        // Enum: VoiceFax, FaxOnly, VoiceOnly
        public string type;
        // Usage type of a phone number
        // Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber, ConferencingNumber
        public string usageType;
        // List of features of a phone number
        public string[] features;
    }
}