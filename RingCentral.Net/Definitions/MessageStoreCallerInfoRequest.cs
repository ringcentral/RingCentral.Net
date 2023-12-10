namespace RingCentral
{
    /// <summary>
    ///     Message sender information. The `phoneNumber` value should be one
    ///     the account phone numbers allowed to send the current type of messages
    /// </summary>
    public class MessageStoreCallerInfoRequest
    {
        /// <summary>
        ///     Phone number in E.164 format
        ///     Required
        /// </summary>
        public string phoneNumber { get; set; }
    }
}