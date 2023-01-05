namespace RingCentral
{
    public class TMAttachmentAuthorInfo
    {
        /// <summary>
        ///     Name of a message author
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Link to an author's name
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Link to an image displayed to the left of an author's name; sized 82x82px
        ///     Format: uri
        /// </summary>
        public string iconUri { get; set; }
    }
}