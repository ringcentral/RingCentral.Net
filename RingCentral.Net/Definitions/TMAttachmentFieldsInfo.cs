namespace RingCentral
{
    public class TMAttachmentFieldsInfo
    {
        /// <summary>
        ///     Title of an individual field
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Value of an individual field (supports Markdown)
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Style of width span applied to a field
        ///     Default: Short
        ///     Enum: Short, Long
        /// </summary>
        public string style { get; set; }
    }
}