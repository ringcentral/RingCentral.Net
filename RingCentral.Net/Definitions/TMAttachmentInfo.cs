namespace RingCentral
{
    public class TMAttachmentInfo
    {
        /// <summary>
        ///     Internal identifier of an attachment
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of an attachment
        ///     Enum: File, Note, Event, Card
        /// </summary>
        public string type { get; set; }
    }
}