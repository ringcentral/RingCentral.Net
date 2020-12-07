namespace RingCentral
{
    // Meeting recording settings locked on account level
    public class UserMeetingRecordingSetting
    {
        /// <summary>
        /// Allows hosts and participants to record a meeting to a local file
        /// </summary>
        public bool? localRecording;

        /// <summary>
        /// Allows hosts to record and save a meeting/webinar in the cloud
        /// </summary>
        public bool? cloudRecording;

        /// <summary>
        /// Allows to record active speaker with the shared screen
        /// </summary>
        public bool? recordSpeakerView;

        /// <summary>
        /// Allows to record gallery view with the shared screen
        /// </summary>
        public bool? recordGalleryView;

        /// <summary>
        /// Allows to record an audio-only file
        /// </summary>
        public bool? recordAudioFile;

        /// <summary>
        /// Allows to save chat text from a meeting
        /// </summary>
        public bool? saveChatText;

        /// <summary>
        /// Allows to show timestamp on video
        /// </summary>
        public bool? showTimestamp;

        /// <summary>
        /// Automatical recording (local/cloud/none) of meetings as they start
        /// Default: local
        /// Enum: local, cloud, none
        /// </summary>
        public string autoRecording;

        /// <summary>
        /// Automatical deletion of cloud recordings
        /// Default: false
        /// </summary>
        public string autoDeleteCmr;

        /// <summary>
        /// A specified number of days for automatical deletion of cloud recordings, the value range is 1-60
        /// </summary>
        public long? autoDeleteCmrDays;
    }
}