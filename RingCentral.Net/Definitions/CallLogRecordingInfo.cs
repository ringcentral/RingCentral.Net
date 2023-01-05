namespace RingCentral
{
    /// <summary>
    ///     Call recording data. Returned if the call was recorded
    /// </summary>
    public class CallLogRecordingInfo
    {
        /// <summary>
        ///     Internal identifier of the call recording
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to the call recording metadata resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Indicates recording mode used
        ///     Enum: Automatic, OnDemand
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Link to a call recording binary content. Has to be retrieved with proper authorization
        ///     (access token must be passed via `Authorization` header or query parameter)
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }
    }
}