namespace RingCentral
{
    /// <summary>
    ///     Linked message (Fax/Voicemail)
    /// </summary>
    public class CallLogRecordMessage
    {
        /// <summary>
        ///     Internal identifier of a message
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of a message
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Link to a message resource
        /// </summary>
        public string uri { get; set; }
    }
}