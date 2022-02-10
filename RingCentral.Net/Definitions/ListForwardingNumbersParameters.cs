namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listForwardingNumbers
    /// </summary>
    public class ListForwardingNumbersParameters
    {
        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are accepted.
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items).
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}