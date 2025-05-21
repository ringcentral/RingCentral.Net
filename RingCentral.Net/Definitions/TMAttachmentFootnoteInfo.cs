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
        ///     Example: Thu Mar 10 2016 10:07:52 GMT-0800 (Pacific Standard Time)
        /// </summary>
        public string time { get; set; }
    }
}