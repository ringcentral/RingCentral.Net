namespace RingCentral
{
    /// <summary>
    ///     Single individual SMS resource
    /// </summary>
    public class MessageCreateRequest
    {
        /// <summary>
        ///     List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format, recipients of this message.
        ///     Currently only one number is supported
        ///     Required
        ///     Example: 15551234567
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     Text to send, maximum number of characters is 1000
        ///     Example: Hello, World!
        /// </summary>
        public string text { get; set; }
    }
}