namespace RingCentral
{
    public class TMNoteInfo
    {
        /// <summary>
        ///     Internal identifier of a note
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Title of a note
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Internal identifiers of the chat(s) where the note is posted or shared.
        /// </summary>
        public string[] chatIds { get; set; }

        /// <summary>
        ///     Preview of a note (first 150 characters of a body)
        /// </summary>
        public string preview { get; set; }

        /// <summary>
        /// </summary>
        public TMCreatorInfo creator { get; set; }

        /// <summary>
        /// </summary>
        public LastModifiedByInfo lastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        public LockedByInfo lockedBy { get; set; }

        /// <summary>
        ///     Note publishing status. Any note is created in 'Draft' status. After it is posted it becomes 'Active'
        ///     Enum: Active, Draft
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Creation time
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Datetime of the note last update
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Enum: Note
        /// </summary>
        public string type { get; set; }
    }
}