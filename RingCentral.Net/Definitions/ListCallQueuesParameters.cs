namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listCallQueues
    /// </summary>
    public class ListCallQueuesParameters
    {
        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values are accepted
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items)
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Internal identifier of an extension that is a member of every group within the result
        /// </summary>
        public string memberExtensionId { get; set; }
    }
}