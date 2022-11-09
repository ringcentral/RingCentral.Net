namespace RingCentral
{
    public class TaskAttachment
    {
        /// <summary>
        ///     File ID.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Possible value: File. Attachment type (currently, only File is possible).
        ///     Enum: File
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Name of the attached file (incl. extension name).
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     URI
        ///     Format: uri
        /// </summary>
        public string contentUri { get; set; }
    }
}