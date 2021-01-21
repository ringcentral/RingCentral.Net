namespace RingCentral
{
    // Extension phone number information
    public class CompanyDirectoryPhoneNumberInfo
    {
        /// <summary>
        /// Extension phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Type of a phone number
        /// Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Specifies if a phone number should be hidden or not. Returned only if the value is 'True'
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        /// Usage type of a phone number
        /// Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber
        /// </summary>
        public string usageType { get; set; }
    }
}