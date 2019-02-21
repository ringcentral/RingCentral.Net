namespace RingCentral
{
    public class ListGlipPostsParameters
    {
        // Identifier of a group to filter posts
        public string groupId;

        // Token of a page to be returned
        public string pageToken;

        // Number of records to be returned. The maximum value is 250, by default - 30
        // Maximum: 250
        // Default: 30
        public long? recordCount;
    }
}