namespace RingCentral
{
    public class AssignPhoneNumberRequest
    {
        /// <summary>
        ///     Type of a phone number
        ///     Enum: VoiceFax, VoiceOnly, FaxOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Target usage type of a phone number (only listed values are supported)
        ///     Required
        ///     Enum: MainCompanyNumber, CompanyNumber, DirectNumber, PhoneLine
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        /// </summary>
        public AssignPhoneNumberRequestExtension extension { get; set; }

        /// <summary>
        /// </summary>
        public string costCenterId { get; set; }
    }
}