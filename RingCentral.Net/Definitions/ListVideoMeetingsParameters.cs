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
        ///     Token to get the next page
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     Number of records returned
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Specify what kind of meeting should be returned. Possible values: All, My, Deleted, Shared
        ///     Request type meaning in meeting search:
        ///     `None` (not passed) - take meetings only where requested acc/ext is participant OR host OR deputy OR watcher.
        ///     `ALL`- access rights of meeting is equal to Alive AND requested acc/ext  is in watchers list OR host OR deputy
        ///     `My`- access rights of meeting is equal to Alive AND requested acc/ext is host OR deputy
        ///     `Shared` - access rights of meeting is equal to Alive AND requested acc/ext is in watcher list AND not HOST
        ///     `Deleted` - access rights of meeting is equal to Delete and requested acc/ext is host OR deputy
        ///     Enum: All, My, Deleted, Shared
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