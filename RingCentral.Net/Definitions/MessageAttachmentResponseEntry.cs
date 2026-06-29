namespace RingCentral
{
    public class MessageAttachmentResponseEntry
    {
        /// <summary>
        ///     Unique identifier of an attachment
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     MIME content type of an attachment
        ///     Required
        ///     Example: audio/mpeg
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Suggested filename of an attachment.
        ///     Example: my-song.mp3
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        ///     Link to the attachment binary content
        ///     Required
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }

        /// <summary>
        ///     Size of the file in bytes
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? size { get; set; }
    }
}