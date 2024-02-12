namespace RingCentral
{
    /// <summary>
    ///     Phone number information
    /// </summary>
    public class DevicePhoneNumberInfo
    {
        /// <summary>
        ///     Internal identifier of a phone number
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// </summary>
        public DevicePhoneNumberCountryInfo country { get; set; }

        /// <summary>
        ///     Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        ///     = ['External', 'TollFree', 'Local']
        ///     Enum: External, TollFree, Local
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Enum: CompanyNumber, MainCompanyNumber, AdditionalCompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        ///     Type of phone number
        ///     Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }
    }
}