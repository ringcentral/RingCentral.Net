namespace RingCentral
{
    public class MessageAttachmentInfoIntId
    {
        /// <summary>
        ///     Internal identifier of a message attachment
        ///     Format: int64
        /// </summary>
        public long? id { get; set; }

        /// <summary>
        ///     Canonical URI of a message attachment
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Type of a message attachment
        ///     Enum: AudioRecording, AudioTranscription, Text, SourceDocument, RenderedDocument, MmsAttachment
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     MIME type for a given attachment, for instance 'audio/wav'
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Name of a file attached
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        ///     Size of an attachment in bytes
        ///     Format: int32
        /// </summary>
        public long? size { get; set; }
    }
}