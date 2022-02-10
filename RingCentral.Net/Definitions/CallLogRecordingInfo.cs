namespace RingCentral
{
    /// <summary>
    ///     Call recording data. Returned if the call is recorded - `withRecording` parameter is set to 'True' in this case
    /// </summary>
    public class CallLogRecordingInfo
    {
        /// <summary>
        ///     Internal identifier of the call recording
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to the call recording metadata resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Indicates recording mode used
        ///     Enum: Automatic, OnDemand
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Link to the call recording binary content
        /// </summary>
        public string contentUri { get; set; }
    }
}