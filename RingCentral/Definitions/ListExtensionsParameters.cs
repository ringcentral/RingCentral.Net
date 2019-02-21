namespace RingCentral
{
    public class ListExtensionsParameters
    {
        // Extension number to retrieve
        public string extensionId;

        // Extension email address
        public string email;

        // Indicates the page number to retrieve. Only positive number values are allowed
        // Default: 1
        public long? page;

        // Indicates the page size (number of items)
        // Default: 100
        public long? perPage;

        // Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned.
        public string[] status;

        // Extension type. Multiple values are supported
        public string[] type;
    }
}