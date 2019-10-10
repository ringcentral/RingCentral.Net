namespace RingCentral
{
    public class DevicePhoneNumberInfo
    {
        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        public long? id;

        /// <summary>
        /// Brief information on a phone number country
        /// </summary>
        public DevicePhoneNumberCountryInfo country;

        /// <summary>
        /// Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system = ['External', 'TollFree', 'Local'],
        /// Enum: External, TollFree, Local
        /// </summary>
        public string paymentType;

        /// <summary>
        /// Phone number
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Enum: CompanyNumber, MainCompanyNumber, AdditionalCompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber
        /// </summary>
        public string usageType;

        /// <summary>
        /// Type of a phone number
        /// Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type;
    }
}