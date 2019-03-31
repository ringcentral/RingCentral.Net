namespace RingCentral
{
    public class PhoneNumberResource
    {
        /// <summary>
        /// </summary>
        public string formattedPhoneNumber;

        /// <summary>
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// </summary>
        public string type;

        /// <summary>
        /// Custom user name of a phone number, if any
        /// </summary>
        public string label;

        /// <summary>
        /// Usage type of a phone number
        /// Enum: MobileNumber, ContactNumber, DirectNumber, ForwardedNumber
        /// </summary>
        public string usageType;
    }
}