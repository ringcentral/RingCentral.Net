namespace RingCentral
{
    public class CallRecordingExtensionResource
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// </summary>
        public string type;

        /// <summary>
        /// Direction of call
        /// Enum: Outbound, Inbound, All
        /// </summary>
        public string callDirection;
    }
}