namespace RingCentral
{
    // Information about the author
    public class GlipMessageAttachmentAuthorInfo
    {
        /// <summary>
        ///     Name of a message author
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Link to an author's name
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Link to an image displayed to the left of an author's name; sized 82x82px
        /// </summary>
        public string iconUri { get; set; }
    }
}