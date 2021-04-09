namespace RingCentral
{
    public class MessageAttachmentInfo
    {
        /// <summary>
        ///     Internal identifier of a message attachment
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of a message attachment
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Type of message attachment
        ///     Enum: AudioRecording, AudioTranscription, Text, SourceDocument, RenderedDocument, MmsAttachment
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     MIME type for a given attachment, for instance 'audio/wav'
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Supported for `Voicemail` only. Duration of a voicemail in seconds
        /// </summary>
        public long? vmDuration { get; set; }

        /// <summary>
        ///     Name of a file attached
        /// </summary>
        public string fileName { get; set; }

        /// <summary>
        ///     Size of attachment in bytes
        /// </summary>
        public long? size { get; set; }

        /// <summary>
        ///     Attachment height in pixels if available
        /// </summary>
        public long? height { get; set; }

        /// <summary>
        ///     Attachment width in pixels if available
        /// </summary>
        public long? width { get; set; }
    }
}