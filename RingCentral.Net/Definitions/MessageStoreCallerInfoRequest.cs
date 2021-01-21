namespace RingCentral
{
    // Message sender information. The `phoneNumber` value should be one the account phone numbers allowed to send the current type of messages
    public class MessageStoreCallerInfoRequest
    {
        /// <summary>
        /// Phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}