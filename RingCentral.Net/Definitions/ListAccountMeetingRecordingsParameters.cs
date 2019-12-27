namespace RingCentral
{
    public class ListAccountMeetingRecordingsParameters
    {
        /// <summary>
        /// Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingId;

        /// <summary>
        /// Recordings of meetings started after the time specified will be returned. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingStartTimeFrom;

        /// <summary>
        /// Recordings of meetings started before the time specified will be returned. The default value is current time. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        /// </summary>
        public string meetingStartTimeTo;

        /// <summary>
        /// Page number
        /// </summary>
        public long? page;

        /// <summary>
        /// Number of items per page. The `max` value is supported to indicate the maximum size - 300
        /// Maximum: 300
        /// Default: 100
        /// </summary>
        public long? perPage;
    }
}