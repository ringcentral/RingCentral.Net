namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation getAccountRecordings
    /// </summary>
    public class GetAccountRecordingsParameters
    {
        /// <summary>
        ///     Token to get the next page
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records returned
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }
    }
}