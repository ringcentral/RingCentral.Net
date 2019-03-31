namespace RingCentral
{
    public class ListExtensionsParameters
    {
        /// <summary>
        /// Extension number to retrieve
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Extension email address
        /// </summary>
        public string email;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned.
        /// </summary>
        public string[] status;

        /// <summary>
        /// Extension type. Multiple values are supported
        /// </summary>
        public string[] type;
    }
}