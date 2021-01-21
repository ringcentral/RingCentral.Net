namespace RingCentral
{
    public class MeetingRecordingInfo
    {
        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link for recording file download
        /// </summary>
        public string contentDownloadUri { get; set; }

        /// <summary>
        /// Enum: video/mp4, audio/m4a, text/plain
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        /// </summary>
        public long? size { get; set; }

        /// <summary>
        /// Starting time of a recording
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        /// Ending time of a recording
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        /// Enum: Completed, Processing
        /// </summary>
        public string status { get; set; }
    }
}