namespace RingCentral
{
    public class ListAccountMeetingRecordingsParameters
    {
        // Internal identifier of a meeting. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingId;

        // Recordings of meetings started after the time specified will be returned. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingStartTimeFrom;

        // Recordings of meetings started before the time specified will be returned. The default value is current time. Either `meetingId` or `meetingStartTime`/`meetingEndTime` can be specified
        public string meetingStartTimeTo;

        // Page number
        public long? page;

        // Number of items per page. The `max` value is supported to indicate the maximum size - 300
        // Maximum: 300
        // Default: 100
        public long? perPage;
    }
}