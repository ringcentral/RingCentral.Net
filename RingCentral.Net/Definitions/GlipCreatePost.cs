namespace RingCentral
{
    public class GlipCreatePost
    {
        /* Title of a message. (Can be set for bot's messages only). */
        public string title;

        /* Text of a post */
        // Maximum: 1000
        public string text;

        /* Internal identifier of a group */
        public string groupId;

        /* List of attachments to be posted */
        public GlipMessageAttachmentInfoRequest[] attachments;
    }
}