namespace RingCentral
{
    // Message footer information
    public class GlipMessageAttachmentFootnoteInfo
    {
        /// <summary>
        /// Text of a footer
        /// </summary>
        public string text;

        /// <summary>
        /// Link to an icon displayed to the left of a footer; sized 32x32px
        /// </summary>
        public string iconUri;

        /// <summary>
        /// Message creation datetime in ISO 8601 format including timezone, for example *2016-03-10T18:07:52.534Z*
        /// </summary>
        public string time;
    }
}