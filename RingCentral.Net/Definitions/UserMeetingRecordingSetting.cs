namespace RingCentral
{
    // Meeting recording settings locked on account level
    public class UserMeetingRecordingSetting
    {
        /// <summary>
        /// Allows hosts and participants to record a meeting to a local file
        /// </summary>
        public bool? localRecording { get; set; }

        /// <summary>
        /// Allows hosts to record and save a meeting/webinar in the cloud
        /// </summary>
        public bool? cloudRecording { get; set; }

        /// <summary>
        /// Allows to record active speaker with the shared screen
        /// </summary>
        public bool? recordSpeakerView { get; set; }

        /// <summary>
        /// Allows to record gallery view with the shared screen
        /// </summary>
        public bool? recordGalleryView { get; set; }

        /// <summary>
        /// Allows to record an audio-only file
        /// </summary>
        public bool? recordAudioFile { get; set; }

        /// <summary>
        /// Allows to save chat text from a meeting
        /// </summary>
        public bool? saveChatText { get; set; }

        /// <summary>
        /// Allows to show timestamp on video
        /// </summary>
        public bool? showTimestamp { get; set; }

        /// <summary>
        /// Automatical recording (local/cloud/none) of meetings as they start
        /// Default: local
        /// Enum: local, cloud, none
        /// </summary>
        public string autoRecording { get; set; }

        /// <summary>
        /// Automatical deletion of cloud recordings
        /// Default: false
        /// </summary>
        public string autoDeleteCmr { get; set; }

        /// <summary>
        /// A specified number of days for automatical deletion of cloud recordings, the value range is 1-60
        /// </summary>
        public long? autoDeleteCmrDays { get; set; }
    }
}