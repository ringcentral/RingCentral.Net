namespace RingCentral
{
    public class RecordingDownloadModel
    {
        /// <summary>
        ///     Download URI (available only for webinar host or admin)
        ///     Required
        ///     Format: uri
        /// </summary>
        public string downloadUri { get; set; }

        /// <summary>
        ///     MIME type of the file to download.
        ///     Required
        ///     Default: video/mp4
        ///     Enum: video/mp4, audio/m4a
        /// </summary>
        public string downloadContentType { get; set; }

        /// <summary>
        ///     Download file size in bytes
        ///     Required
        ///     Format: int64
        ///     Example: 20821092300
        /// </summary>
        public long? downloadSize { get; set; }
    }
}