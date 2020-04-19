namespace RingCentral
{
    public class GlipNoteInfo
    {
        /// <summary>
        /// Internal identifier of a note
        /// </summary>
        public string id;

        /// <summary>
        /// Title of a note
        /// </summary>
        public string title;

        /// <summary>
        /// Internal identifiers of the chat(s) where the note is posted or shared.
        /// </summary>
        public string[] chatIds;

        /// <summary>
        /// Preview of a note (first 150 characters of a body)
        /// </summary>
        public string preview;

        /// <summary>
        /// Note creator information
        /// </summary>
        public CreatorInfo creator;

        /// <summary>
        /// Note last modification information
        /// </summary>
        public LastModifiedByInfo lastModifiedBy;

        /// <summary>
        /// Returned for the note being edited (locked) at the current moment. Information on the user editing the note
        /// </summary>
        public LockedByInfo lockedBy;

        /// <summary>
        /// Note publishing status. Any note is created in 'Draft' status. After it is posted it becomes 'Active'
        /// Enum: Active, Draft
        /// </summary>
        public string status;

        /// <summary>
        /// Creation time
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Datetime of the note last update
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// Enum: Note
        /// </summary>
        public string type;
    }
}