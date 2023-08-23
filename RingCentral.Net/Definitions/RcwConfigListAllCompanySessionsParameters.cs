namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation rcwConfigListAllCompanySessions
    /// </summary>
    public class RcwConfigListAllCompanySessionsParameters
    {
        /// <summary>
        ///     Session status (for the purposes of Configuration service)
        ///     Example: Scheduled
        ///     Enum: Scheduled, Active, Finished
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     The beginning of the time window by 'endTime' (it is calculated as scheduledStartTime+scheduledDuration)
        ///     Format: date-time
        /// </summary>
        public string endTimeFrom { get; set; }

        /// <summary>
        ///     Identifier of the user who hosts a webinar (if omitted, webinars hosted by all company users will be returned)
        ///     Example: 77777777
        /// </summary>
        public string[] hostUserId { get; set; }

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