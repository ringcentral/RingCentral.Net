namespace RingCentral
{
    public class TMAttachmentFootnoteInfo
    {
        /// <summary>
        ///     Text of a footer
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Link to an icon displayed to the left of a footer; sized 32x32px
        ///     Format: uri
        /// </summary>
        public string iconUri { get; set; }

        /// <summary>
        ///     Message creation datetime in ISO 8601 format including timezone
        ///     Format: date-time
        ///     Example: 2016-03-10T18:07:52.534Z
        /// </summary>
        public string time { get; set; }
    }
}