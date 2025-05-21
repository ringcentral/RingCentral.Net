namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listSmsOptRecords
    /// </summary>
    public class ListSmsOptRecordsParameters
    {
        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

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
        ///     The sender's phone number(s) to filter records
        /// </summary>
        public string[] from { get; set; }

        /// <summary>
        ///     The recipient's phone number(s) to filter records
        /// </summary>
        public string[] to { get; set; }

        /// <summary>
        ///     The opt status to filter records. If omitted, `OptOut` records` are returned
        ///     Default: OptOut
        ///     Enum: OptOut, OptIn
        /// </summary>
        public string[] optStatus { get; set; }
    }
}