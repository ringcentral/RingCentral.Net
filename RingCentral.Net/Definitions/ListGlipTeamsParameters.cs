namespace RingCentral
{
    public class ListGlipTeamsParameters
    {
        /* Number of teams to be fetched by one request. The maximum value is 250, by default - 30 */
        // Maximum: 250
        // Default: 30
        public long? recordCount;

        /* Pagination token. */
        public string pageToken;
    }
}