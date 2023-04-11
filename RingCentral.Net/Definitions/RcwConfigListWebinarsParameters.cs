namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwConfigListWebinars
    /// </summary>
    public class RcwConfigListWebinarsParameters
    {
        /// <summary>
        ///     The beginning of the time window by 'creationTime' .
        ///     Format: date-time
        /// </summary>
        public string creationTimeFrom { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }
    }
}