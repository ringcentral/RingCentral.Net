namespace RingCentral
{
    public class ListCallQueuesParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// Internal identifier of an extension that is a member of every group within the result
        /// </summary>
        public string memberExtensionId { get; set; }
    }
}