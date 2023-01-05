namespace RingCentral
{
    public class GetCallRecordingResponse
    {
        /// <summary>
        ///     Internal identifier of a call recording
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a call recording binary content. Has to be retrieved with proper authorization
        ///     (access token must be passed via `Authorization` header or query parameter)
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Call recording file format. Supported format is audio/x-wav
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Recorded call duration
        ///     Format: int32
        /// </summary>
        public long? duration { get; set; }
    }
}