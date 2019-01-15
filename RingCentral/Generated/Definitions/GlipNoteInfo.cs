using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipNoteInfo : Serializable
    {
        // Internal identifier of a note
        public string id;
        // Title of a note
        public string title;
        // Preview of a note (first 150 characters of a body)
        public string preview;
        // Internal identifier of a note creator
        public string creatorId;
        // Internal identifier of the person editing the note. Returned for the note being edited (locked) at the moment
        public string lockedBy;
        // Status of a note. Any note is created in 'Draft' status. After it is posted it becomes 'Active'
        // Enum: Active, Draft
        public string status;
        // Creation time
        public string creationTime;
        // Datetime of the note last update
        public string lastModifiedTime;
    }
}