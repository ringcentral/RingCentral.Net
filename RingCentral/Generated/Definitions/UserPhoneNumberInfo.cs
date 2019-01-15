using Newtonsoft.Json;

namespace RingCentral.Net
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
        public string paymentType;
        // Phone number
        public string phoneNumber;
        // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        public string status;
        // Phone number type
        public string type;
        // Usage type of a phone number
        public string usageType;
        // List of features of a phone number
        public string[] features;
    }
}