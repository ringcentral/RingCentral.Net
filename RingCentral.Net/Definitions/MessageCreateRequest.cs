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

        /// <summary>
        /// Scheduled time to send this message. Overrides batch's `scheduledAt` attribute when sending
        /// </summary>
        public string scheduledAt;

        /// <summary>
        /// Number of seconds since `scheduledAt` this message is relevant for. If more time than `expiresIn` has passed since `scheduledAt` (or current time, if no scheduled time specified) and the message has not been sent yet, it becomes discarded.
        /// </summary>
        public long? expiresIn;
    }
}