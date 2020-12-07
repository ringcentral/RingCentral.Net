namespace RingCentral
{
    // Message sender information. The `phoneNumber` value should be one the account phone numbers allowed to send media messages || Message sender information. The `phoneNumber` value should be one the account phone numbers allowed to send text messages
    public class MessageStoreCallerInfoRequest
    {
        /// <summary>
        /// Phone number in E.164 format
        /// </summary>
        public string phoneNumber;
    }
}