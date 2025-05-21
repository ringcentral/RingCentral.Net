namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation getExtensionRecordings
    /// </summary>
    public class GetExtensionRecordingsParameters
    {
        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}