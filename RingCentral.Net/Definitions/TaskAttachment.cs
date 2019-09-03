namespace RingCentral
{
    public class TaskAttachment
    {
        /// <summary>
        /// Internal identifier of a file
        /// </summary>
        public string id;

        /// <summary>
        /// Attachment type (currently only `File` value is supported).
        /// Enum: File
        /// </summary>
        public string type;

        /// <summary>
        /// Name of the attached file (including extension name).
        /// </summary>
        public string name;

        /// <summary>
        /// Link to an attachment content
        /// </summary>
        public string contentUri;
    }
}