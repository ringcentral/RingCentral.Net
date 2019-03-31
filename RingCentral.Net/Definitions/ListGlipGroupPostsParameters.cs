namespace RingCentral
{
    public class ListGlipGroupPostsParameters
    {
        /* Max number of records to be returned */
        // Maximum: 250
        // Default: 30
        public long? recordCount;

        /* Pagination token */
        public string pageToken;
    }
}