using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipNoteCreate : Serializable
    {
        // Title of a note
        public string title;
        // If a note should be immediately published then pass 'Active' value. This doesn't create a new post in the current group but as a result the note can be read by members of this group
        // Enum: Active, Draft
        public string status;
        // Contents of a note
        public string body;
    }
}