using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageAttachmentInfoIntId : Serializable
    {
        // Internal identifier of a message attachment
        public int? id;
        // Canonical URI of a message attachment
        public string uri;
        // Type of message attachment
        public string type;
        // MIME type for a given attachment, for instance 'audio/wav'
        public string contentType;
        // Voicemail only Duration of the voicemail in seconds
        public int? vmDuration;
        // Name of a file attached
        public string filename;
        // Size of attachment in bytes
        public int? size;
    }
}