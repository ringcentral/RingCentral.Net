namespace RingCentral
{
    public class ListCallMonitoringGroupMembersParameters
    {
        /* Indicates the page number to retrieve. Only positive number values are allowed */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;
    }
}