namespace RingCentral
{
    // Query parameters for operation listAccountMeetingRecordings
    public class ListAccountMeetingRecordingsParameters
    {
        /// <summary>
        ///     Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingId { get; set; }

        /// <summary>
        ///     Recordings of meetings started after the time specified will be returned. Either `meetingId` or
        ///     `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingStartTimeFrom { get; set; }

        /// <summary>
        ///     Recordings of meetings started before the time specified will be returned. The default value is current time.
        ///     Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
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