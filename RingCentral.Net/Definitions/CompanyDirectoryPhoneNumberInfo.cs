namespace RingCentral
{
    public class CompanyDirectoryPhoneNumberInfo
    {
        /// <summary>
        /// Extension phone number in E.164 format
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Type of a phone number
        /// Enum: VoiceFax, FaxOnly, VoiceOnly
        /// </summary>
        public string type;

        /// <summary>
        /// Specifies if a phone number should be hidden or not. Returned only if the value is 'True'
        /// </summary>
        public bool? hidden;

        /// <summary>
        /// Usage type of a phone number
        /// Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber
        /// </summary>
        public string usageType;
    }
}