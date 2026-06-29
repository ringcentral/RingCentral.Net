namespace RingCentral
{
    public class ThreadNoteModel
    {
        /// <summary>
        ///     Internal identifier of a note
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of a message thread
        ///     Required
        /// </summary>
        public string threadId { get; set; }

        /// <summary>
        ///     Thread/message availability
        ///     Required
        ///     Enum: Alive, Deleted
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        ///     Note creation date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Message last modification date/time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Message or note text
        ///     Example: Hello, how are you doing today?
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Thread note author
        /// </summary>
        public ThreadNoteModelAuthor author { get; set; }
    }
}