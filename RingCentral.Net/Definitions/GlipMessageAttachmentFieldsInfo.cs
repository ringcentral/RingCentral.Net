namespace RingCentral
{
    public class GlipMessageAttachmentFieldsInfo
    {
        /// <summary>
        /// Title of an individual field
        /// </summary>
        public string title;

        /// <summary>
        /// Value of an individual field (supports Markdown)
        /// </summary>
        public string value;

        /// <summary>
        /// Style of width span applied to a field
        /// Default: Short
        /// Enum: Short, Long
        /// </summary>
        public string style;
    }
}