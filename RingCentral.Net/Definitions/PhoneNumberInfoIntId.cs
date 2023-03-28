namespace RingCentral
{
    /// <summary>
    ///     Phone number information
    /// </summary>
    public class PhoneNumberInfoIntId
    {
        /// <summary>
        ///     Internal identifier of a phone number
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberCountryInfo country { get; set; }

        /// <summary>
        /// </summary>
        public DeviceProvisioningExtensionInfo extension { get; set; }

        /// <summary>
        ///     Custom user name of a phone number, if any
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Location (City, State). Filled for local US numbers
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Payment type. 'External' is returned for forwarded numbers
        ///     which are not terminated in the RingCentral phone system
        ///     Enum: External, TollFree, Local
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is 'Normal', the phone
        ///     number is ready to be used. Otherwise it is an external number not yet
        ///     ported to RingCentral
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Phone number type
        ///     Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Usage type of the phone number
        ///     Enum: MainCompanyNumber, AdditionalCompanyNumber, CompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber,
        ///     ForwardedCompanyNumber, ContactCenterNumber
        /// </summary>
        public string usageType { get; set; }
    }
}