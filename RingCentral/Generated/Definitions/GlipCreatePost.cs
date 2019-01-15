using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipCreatePost : Serializable
    {
        // Title of a message. (Can be set for bot's messages only).
        public string title;
        // Text of a post
        public string text;
        // Internal identifier of a group
        public string groupId;
        // List of attachments to be posted
        public GlipMessageAttachmentInfoRequest[] attachments;
    }
}