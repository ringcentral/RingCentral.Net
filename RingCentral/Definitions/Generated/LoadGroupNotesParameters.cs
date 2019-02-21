namespace RingCentral
{
    public class LoadGroupNotesParameters
    {
        // Number of groups to be fetched by one request, the maximum value is 250, the default is 30
        // Maximum: 250
        // Default: 30
        public long? recordCount;

        // Token of a page to be returned
        public string pageToken;

        // Status of notes to be fetched. If not specified all notes are returned
        // Enum: Active, Draft, Unknown
        public string status;

        // Internal identifier of a note author
        public string creatorId;
    }
}