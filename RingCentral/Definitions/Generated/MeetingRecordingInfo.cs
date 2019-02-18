namespace RingCentral
{
    public class MeetingRecordingInfo
    {
        public string id;

        public string contentDownloadUri;

        // Enum: video/mp4, audio/m4a, text/vtt
        public string contentType;

        public long? size;

        // Starting time of a recording
        public string startTime;

        // Ending time of a recording
        public string endTime;

        // Enum: Completed, Processing
        public string status;
    }
}