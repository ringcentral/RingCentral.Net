namespace RingCentral
{
    public class ListCallQueuesParameters
    {
        /* Indicates the page number to retrieve. Only positive number values are accepted */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;

        /* Internal identifier of an extension that is a member of every group within the result */
        public string memberExtensionId;
    }
}