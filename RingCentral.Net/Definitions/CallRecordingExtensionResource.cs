namespace RingCentral
{
    public class CallRecordingExtensionResource
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Direction of call
        /// Enum: Outbound, Inbound, All
        /// </summary>
        public string callDirection { get; set; }
    }
}