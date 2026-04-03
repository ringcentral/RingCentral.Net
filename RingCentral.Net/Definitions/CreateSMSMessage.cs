namespace RingCentral
{
    public class CreateSMSMessage
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MessageStoreCallerInfoRequest from { get; set; }

        /// <summary>
        ///     Message receiver(s) information. The `phoneNumber` value is required
        ///     Required
        /// </summary>
        public MessageStoreCallerInfoRequest[] to { get; set; }

        /// <summary>
        ///     Text of a message. Max length is 1000 symbols (2-byte UTF-16
        ///     encoded). If a character is encoded in 4 bytes in UTF-16 it is treated
        ///     as 2 characters, thus restricting the maximum message length to 500 symbols
        ///     Required
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// </summary>
        public SmsRequestCountryInfo country { get; set; }
    }
}