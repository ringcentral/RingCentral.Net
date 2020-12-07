namespace RingCentral
{
    public class CreateMMSMessage
    {
        /// <summary>
        /// Required
        /// </summary>
        public MessageStoreCallerInfoRequest from;

        /// <summary>
        /// Message receiver(s) information. The `phoneNumber` value is required
        /// Required
        /// </summary>
        public MessageStoreCallerInfoRequest[] to;

        /// <summary>
        /// Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols
        /// </summary>
        public string text;

        /// <summary>
        /// </summary>
        public MessageCountryInfo country;

        /// <summary>
        /// Files to send
        /// Required
        /// </summary>
        public Attachment[] attachments;
    }
}