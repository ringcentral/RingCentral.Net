namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwHistoryGetRecordingDownload
    /// </summary>
    public class RcwHistoryGetRecordingDownloadParameters
    {
        /// <summary>
        ///     Recording file media type. 'Video' implies multiplexed audio and video. 'Audio' refers to audio only.
        ///     Example: Video
        ///     Default: Video
        ///     Enum: Video, Audio
        /// </summary>
        public string recordingMediaType { get; set; }
    }
}