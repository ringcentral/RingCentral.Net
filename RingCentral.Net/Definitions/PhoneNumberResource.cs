namespace RingCentral
{
    public class PhoneNumberResource
    {
        /// <summary>
        /// </summary>
        public string formattedPhoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Custom user name of a phone number, if any
        /// </summary>
        public string label { get; set; }

        /// <summary>
        ///     Usage type of a phone number
        ///     Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber
        /// </summary>
        public string usageType { get; set; }

        /// <summary>
        ///     Specifies if a phone number should be hidden or not
        /// </summary>
        public bool? hidden { get; set; }

        /// <summary>
        ///     Specifies if the number is primary, i.e. displayed as 'main number' and called by default
        /// </summary>
        public bool? primary { get; set; }
    }
}