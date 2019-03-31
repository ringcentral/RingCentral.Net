namespace RingCentral
{
    public class ListFaxCoverPagesParameters
    {
        /* Indicates the page number to retrieve. Only positive number values are accepted */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;
    }
}