namespace RingCentral
{
    public class CreateMMSMessage
    {
        /// <summary>
        /// Sender of an SMS message. The phoneNumber property must be filled to correspond to one of the account phone numbers which is allowed to send SMS
        /// Required
        /// </summary>
        public MessageStoreCallerInfoRequest from;

        /// <summary>
        /// Receiver of an SMS message. The phoneNumber property must be filled
        /// Required
        /// </summary>
        public MessageStoreCallerInfoRequest[] to;

        /// <summary>
        /// Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols
        /// Required
        /// </summary>
        public string text;

        /// <summary>
        /// </summary>
        public SMSCountryInfo country;

        /// <summary>
        /// Files to send
        /// </summary>
        public Attachment[] attachments;
    }
}