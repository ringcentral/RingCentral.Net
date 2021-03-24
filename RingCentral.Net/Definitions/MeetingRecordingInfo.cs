namespace RingCentral
{
    public class MeetingRecordingInfo
    {
        /// <summary>
        /// Unique identifier of a meeting instance
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Link for downloading the recorded file (mp4, mp3 audio and text/plain chat file)
        /// </summary>
        public string contentDownloadUri { get; set; }

        /// <summary>
        /// Enum: video/mp4, audio/m4a, text/plain
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        /// Format: int32
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