namespace RingCentral
{
    // Single individual SMS resource
    public class MessageCreateRequest
    {
        /// <summary>
        /// List of phone numbers in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format, recipients of this message. Currently only one number is supported
        /// Required
        /// </summary>
        public string[] to;

        /// <summary>
        /// Text to send
        /// </summary>
        public string text;
    }
}