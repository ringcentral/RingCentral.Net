namespace RingCentral
{
    public class GetCallRecordingResponse
    {
        /// <summary>
        /// Internal identifier of a call recording
        /// </summary>
        public string id;

        /// <summary>
        /// Link to a call recording binary content
        /// </summary>
        public string contentUri;

        /// <summary>
        /// Call recording file format. Supported format is audio/x-wav
        /// </summary>
        public string contentType;

        /// <summary>
        /// Recorded call duration
        /// </summary>
        public long? duration;
    }
}