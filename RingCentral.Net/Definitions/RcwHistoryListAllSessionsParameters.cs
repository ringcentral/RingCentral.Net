namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwHistoryListAllSessions
    /// </summary>
    public class RcwHistoryListAllSessionsParameters
    {
        /// <summary>
        ///     Filter to return only webinar sessions containing particular substring within their names
        ///     Example: All-hands
        /// </summary>
        public string nameFragment { get; set; }

        /// <summary>
        ///     Filter to return only webinar sessions in certain status. Multiple values are supported.
        ///     Example: Active,Finished
        ///     Enum: Scheduled, Active, Finished
        /// </summary>
        public string[] status { get; set; }

        /// <summary>
        ///     The beginning of the time window by 'endTime' .
        ///     Format: date-time
        /// </summary>
        public string endTimeFrom { get; set; }

        /// <summary>
        ///     The end of the time window by 'endTime' .
        ///     Format: date-time
        /// </summary>
        public string endTimeTo { get; set; }

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