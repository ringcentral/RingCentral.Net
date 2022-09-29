namespace RingCentral
{
    public class GlipCreatePost
    {
        /// <summary>
        /// </summary>
        public string activity { get; set; }

        /// <summary>
        ///     Title of a message. (Can be set for bot's messages only).
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Text of a post
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Internal identifier of a group
        /// </summary>
        public string groupId { get; set; }

        /// <summary>
        ///     List of attachments to be posted
        /// </summary>
        public GlipMessageAttachmentInfoRequest[] attachments { get; set; }

        /// <summary>
        /// </summary>
        public string[] personIds { get; set; }

        /// <summary>
        /// </summary>
        public bool? system { get; set; }
    }
}