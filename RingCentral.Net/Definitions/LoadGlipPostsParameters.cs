namespace RingCentral
{
    public class LoadGlipPostsParameters
    {
        /* Max number of posts to be fetched by one request (Not more than 250). */
        // Maximum: 250
        // Default: 30
        public long? recordCount;

        /* Pagination token. */
        public string pageToken;
    }
}