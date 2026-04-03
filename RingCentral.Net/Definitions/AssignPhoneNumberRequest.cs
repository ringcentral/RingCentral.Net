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
        ///     Target usage type of phone number (only listed values are supported)
        ///     Required
        ///     Enum: MainCompanyNumber, CompanyNumber, DirectNumber, ContactCenterNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        /// </summary>
        public AssignPhoneNumberRequestExtension extension { get; set; }

        /// <summary>
        /// </summary>
        public string costCenterId { get; set; }

        /// <summary>
        /// </summary>
        public ContactCenterProvider contactCenterProvider { get; set; }
    }
}