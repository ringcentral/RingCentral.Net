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
        ///     Voicemail only Duration of the voicemail in seconds
        /// </summary>
        public long? vmDuration { get; set; }

        /// <summary>
        ///     Name of a file attached
        /// </summary>
        public string filename { get; set; }

        /// <summary>
        ///     Size of attachment in bytes
        /// </summary>
        public long? size { get; set; }
    }
}