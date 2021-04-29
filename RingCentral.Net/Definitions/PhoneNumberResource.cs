namespace RingCentral
{
    public class PhoneNumberResource
    {
        /// <summary>
        ///     Internal identifier of a phone number
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public DeviceCountryResource country { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberExtensionInfo extension { get; set; }

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
        ///     Enum: External, TollFree, Local
        /// </summary>
        public string paymentType { get; set; }

        /// <summary>
        ///     Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Enum: CompanyNumber, MainCompanyNumber, AdditionalCompanyNumber, DirectNumber, CompanyFaxNumber, ForwardedNumber, ForwardedCompanyNumber, ContactCenterNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }
    }
}