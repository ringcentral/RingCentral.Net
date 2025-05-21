namespace RingCentral
{
    public class SessionGlobalResource
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Object creation time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Object last modification time
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public WebinarRefModel webinar { get; set; }

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
        ///     Session locale code. Can't be blank or null.
        ///     Example: en-US
        ///     Default: en-US
        /// </summary>
        public string localeCode { get; set; }

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
        ///     Webinar session status
        ///     Example: Finished
        ///     Enum: Scheduled, Active, Finished
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Session runtime status (for 'Active' Sessions only).
        ///     Please note that 'Idle' status shouldn't be returned in the API
        ///     (but can be delivered in an event)
        ///     Example: Live
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

        /// <summary>
        ///     The RCV bridge id
        ///     Example: 839874770
        /// </summary>
        public string videoBridgeId { get; set; }

        /// <summary>
        /// </summary>
        public RecordingModel recording { get; set; }

        /// <summary>
        ///     The list of livestreams configured for the session
        /// </summary>
        public SessionLivestreamMinimalModel[] livestreams { get; set; }
    }
}