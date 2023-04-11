namespace RingCentral
{
    public class SessionRefModel
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

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
        /// </summary>
        public WebinarRefModel webinar { get; set; }
    }
}