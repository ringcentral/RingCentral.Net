namespace RingCentral
{
    // Linked message (Fax/Voicemail)
    public class CallLogRecordMessage
    {
        /// <summary>
        /// Internal identifier of a message
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a message
        /// </summary>
        public string type;

        /// <summary>
        /// Link to a message resource
        /// </summary>
        public string uri;
    }
}