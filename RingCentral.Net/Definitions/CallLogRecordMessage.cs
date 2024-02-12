namespace RingCentral
{
    /// <summary>
    ///     Linked message (Fax/Voicemail)
    /// </summary>
    public class CallLogRecordMessage
    {
        /// <summary>
        ///     Internal identifier of a message
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of message
        ///     Required
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Link to a message resource
        ///     Required
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}