namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listAccountMeetings
    /// </summary>
    public class ListAccountMeetingsParameters
    {
        /// <summary>
        ///     The token indicating the particular page of the result set to be retrieved.
        ///     If omitted the first page will be returned.
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of meeting records requested
        ///     Maximum: 100
        ///     Minimum: 10
        ///     Format: int32
        ///     Default: 25
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     ISO 8601 datetime value used to filter meetings that represents the beginning of the range for `startTime`
        ///     Format: date-time
        /// </summary>
        public string startTimeFrom { get; set; }

        /// <summary>
        ///     ISO 8601 datetime value used to filter meetings that represents the end of the range for `startTime`
        ///     Format: date-time
        /// </summary>
        public string startTimeTo { get; set; }

        /// <summary>
        ///     Comma-separated list of fields with optional sort direction. Use a '+' prefix for ascending order or '-' for
        ///     descending order. E.g., orderBy=+startTime
        ///     Default: -startTime
        /// </summary>
        public string orderBy { get; set; }
    }
}