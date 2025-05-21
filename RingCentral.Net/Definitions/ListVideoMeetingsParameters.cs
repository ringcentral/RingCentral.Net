namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listVideoMeetings
    /// </summary>
    public class ListVideoMeetingsParameters
    {
        /// <summary>
        ///     Search text
        /// </summary>
        public string text { get; set; }

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

        /// <summary>
        ///     Specifies types meeting to be returned. Possible values:
        ///     -
        ///     <empty>
        ///         (not passed) - return only the meetings where the requesting user is the participant OR host OR deputy OR
        ///         watcher;
        ///         - `All`- return `Alive` meetings where the requesting user is the host OR deputy OR watcher;
        ///         - `My`- return `Alive` meetings where the requesting user is the host OR deputy;
        ///         - `Shared` - return `Alive` meetings where the requesting user is the watcher AND not host;
        ///         - `Deleted` - return `Deleted` meetings where the requesting user is the host OR deputy.
        ///         Enum: All, My, Deleted, Shared
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Unix timestamp in milliseconds (inclusive) indicates the start time of meetings which should be included in
        ///     response
        ///     Format: int64
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        ///     Unix timestamp in milliseconds (inclusive) indicates the end time of meetings which should be included in response
        ///     Format: int64
        /// </summary>
        public long? endTime { get; set; }
    }
}