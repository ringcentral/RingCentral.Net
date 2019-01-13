using Newtonsoft.Json;

namespace RingCentral
{
    public class PhoneNumberResourceIntId : Serializable
    {
        // Internal identifier of a phone number
        public long? id;
        // Brief information on a phone number country
        public CountryResource country;
        // Information on an extension to which the phone number is assigned
        public ExtensionResource extension;
        // Custom user name of a phone number, if any. Supported for numbers assigned to Auto-Receptionist, with usage type 'CompanyNumber' 
        public string label;
        // Location (City, State). Filled for local US numbers
        public string location;
        // Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system = ['External', 'TollFree', 'Local'],
        public string paymentType;
        // Phone number
        public string phoneNumber;
        // Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral ,
        public string status;
        public string usageType;
        // Type of a phone number
        public string type;
    }
}