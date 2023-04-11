namespace RingCentral
{
    public class GetCallRecordingResponse
    {
        /// <summary>
        ///     Internal identifier of a call recording
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a call recording binary content. Has to be retrieved with proper authorization
        ///     (access token must be passed via `Authorization` header or query parameter)
        ///     Required
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Call recording file format. Supported format is audio/x-wav
        ///     Required
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Recorded call duration
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? duration { get; set; }
    }
}