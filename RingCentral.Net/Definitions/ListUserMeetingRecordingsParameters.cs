namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserMeetingRecordings
    /// </summary>
    public class ListUserMeetingRecordingsParameters
    {
        /// <summary>
        ///     Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingId { get; set; }

        /// <summary>
        ///     Recordings of meetings started after the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format, will be returned, for example *2016-03-10T18:07:52.534Z*. Either `meetingId` or
        ///     `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingStartTimeFrom { get; set; }

        /// <summary>
        ///     Recordings of meetings started before the time specified in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601)
        ///     format will be returned, for example *2016-03-10T18:07:52.534Z*. The default value is current time. Either
        ///     `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingStartTimeTo { get; set; }

        /// <summary>
        ///     Page number
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of items per page. The `max` value is supported to indicate the maximum size - 300
        ///     Maximum: 300
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}