namespace RingCentral
{
    public class MessageAttachmentInfo
    {
        /* Internal identifier of a message attachment */
        public string id;

        /* Canonical URI of a message attachment */
        public string uri;

        /* Type of message attachment */
        // Enum: AudioRecording, AudioTranscription, Text, SourceDocument, RenderedDocument, MmsAttachment
        public string type;

        /* MIME type for a given attachment, for instance 'audio/wav' */
        public string contentType;

        /* Supported for `Voicemail` only. Duration of a voicemail in seconds */
        public long? vmDuration;

        /* Name of a file attached */
        public string filename;

        /* Size of attachment in bytes */
        public long? size;
    }
}