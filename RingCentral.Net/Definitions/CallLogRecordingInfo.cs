namespace RingCentral
{
    // Call recording data. Returned if a call is recorded || Call recording data. Returned if the call is recorded || Call recording data. Returned if the call is recorded - `withRecording` parameter is set to 'True' in this case
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