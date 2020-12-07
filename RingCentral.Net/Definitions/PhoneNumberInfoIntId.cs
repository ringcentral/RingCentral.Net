namespace RingCentral
{
    // Phone number information
    public class PhoneNumberInfoIntId
    {
        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        public long? id;

        /// <summary>
        /// </summary>
        public PhoneNumberCountryInfo country;

        /// <summary>
        /// </summary>
        public DeviceProvisioningExtensionInfo extension;

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
        /// Usage type of the phone number
        /// Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber
        /// </summary>
        public string usageType;
    }
}