namespace RingCentral
{
    public class GlipCreatePost
    {
        /// <summary>
        /// Title of a message. (Can be set for bot's messages only).
        /// </summary>
        public string title;

        /// <summary>
        /// Text of a post
        /// Maximum: 1000
        /// </summary>
        public string text;

        /// <summary>
        /// Internal identifier of a group
        /// </summary>
        public string groupId;

        /// <summary>
        /// List of attachments to be posted
        /// </summary>
        public GlipMessageAttachmentInfoRequest[] attachments;
    }
}