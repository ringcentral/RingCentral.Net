namespace RingCentral
{
    public class CallLogRecordingInfo
    {
        /// <summary>
        /// Internal identifier of the call recording
        /// </summary>
        public string id;

        /// <summary>
        /// Link to the call recording metadata resource
        /// </summary>
        public string uri;

        /// <summary>
        /// Indicates recording mode used
        /// Enum: Automatic, OnDemand
        /// </summary>
        public string type;

        /// <summary>
        /// Link to the call recording binary content
        /// </summary>
        public string contentUri;
    }
}