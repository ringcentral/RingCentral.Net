namespace RingCentral
{
    public class CallRecordingExtensionResource
    {
        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Direction of a call
        ///     Enum: Outbound, Inbound, All
        /// </summary>
        public string callDirection { get; set; }

        /// <summary>
        ///     Alternate call recording setting. Status of the smart ACR for outbound call recordings.
        ///     Supported for "Outbound" and "All" call directions.
        /// </summary>
        public bool? alternateOutboundCallRecordingMode { get; set; }
    }
}