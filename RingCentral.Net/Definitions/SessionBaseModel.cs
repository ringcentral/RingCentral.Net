namespace RingCentral
{
    public class SessionBaseModel
    {
        /// <summary>
        ///     Session start time. If a session hasn't been started this fields should be set to "scheduledStartTime"
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Session end time. If a session hasn't been finished this fields should be set to ("startTime"+"scheduledDuration")
        ///     Format: date-time
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        ///     Session duration in seconds rounded up (returned if 'startTime' and 'endTime' are not empty)
        ///     Format: int32
        ///     Example: 3600
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     Session title. If blank - derived from webinar title.
        ///     Example: Live Broadcasting US
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     User-friendly description of the Session. If blank - derived from webinar title.
        ///     Example: Live session for US-based participants
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Session scheduled start time.
        ///     Format: date-time
        /// </summary>
        public string scheduledStartTime { get; set; }

        /// <summary>
        ///     The scheduled duration of the Session in seconds.
        ///     Format: int32
        ///     Example: 1800
        /// </summary>
        public long? scheduledDuration { get; set; }

        /// <summary>
        ///     IANA-compatible time zone name (see https://www.iana.org/time-zones).
        ///     Example: America/New_York
        /// </summary>
        public string timeZone { get; set; }

        /// <summary>
        ///     The time offset (positive, in seconds) indicating how much in advance
        ///     (comparing to "scheduledStartTime") panel members should join for the pre-webinar team sync
        ///     Format: int32
        ///     Example: 900
        /// </summary>
        public long? panelJoinTimeOffset { get; set; }

        /// <summary>
        ///     The time when broadcasting started.
        ///     Format: date-time
        /// </summary>
        public string broadcastingStartTime { get; set; }

        /// <summary>
        ///     The time when broadcasting ended.
        ///     Format: date-time
        /// </summary>
        public string broadcastingEndTime { get; set; }

        /// <summary>
        ///     Session status from Configuration service
        ///     Example: Finished
        ///     Enum: Scheduled, Active, Finished
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Session runtime status (for 'Active' Sessions only).
        ///     It is omitted (or null) if the status is not Active
        ///     Enum: Idle, Practice, GoingLive, Live, Break, Debrief
        /// </summary>
        public string runtimeStatus { get; set; }

        /// <summary>
        ///     The number of participants (of all roles) who joined the webinar
        ///     Format: int32
        ///     Example: 150
        /// </summary>
        public long? participantCount { get; set; }

        /// <summary>
        ///     The number of attendees who joined the webinar
        ///     Format: int32
        ///     Example: 145
        /// </summary>
        public long? attendeeCount { get; set; }

        /// <summary>
        ///     Unique number of participants (of all roles) who joined the webinar
        ///     Format: int32
        ///     Example: 140
        /// </summary>
        public long? uniqueParticipantCount { get; set; }

        /// <summary>
        ///     Unique number of attendees who joined the webinar
        ///     Format: int32
        ///     Example: 135
        /// </summary>
        public long? uniqueAttendeeCount { get; set; }
    }
}