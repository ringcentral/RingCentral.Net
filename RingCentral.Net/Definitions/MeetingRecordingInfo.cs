namespace RingCentral
{
    public class MeetingRecordingInfo
    {
        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public string contentDownloadUri;

        /// <summary>
        /// Enum: video/mp4, audio/m4a, text/vtt
        /// </summary>
        public string contentType;

        /// <summary>
        /// </summary>
        public long? size;

        /// <summary>
        /// Starting time of a recording
        /// </summary>
        public string startTime;

        /// <summary>
        /// Ending time of a recording
        /// </summary>
        public string endTime;

        /// <summary>
        /// Enum: Completed, Processing
        /// </summary>
        public string status;
    }
}