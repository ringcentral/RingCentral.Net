namespace RingCentral
{
    /// <summary>
    ///     Meeting information
    /// </summary>
    public class Meeting
    {
        /// <summary>
        ///     Call id
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Bridge id
        ///     Required
        /// </summary>
        public string bridgeId { get; set; }

        /// <summary>
        ///     Short bridge id
        ///     Required
        /// </summary>
        public string shortId { get; set; }

        /// <summary>
        ///     Start time ISO 8601
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Duration second
        ///     Format: int32
        ///     Example: 36
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     Meetings name
        ///     Required
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Meeting type
        ///     Required
        ///     Enum: Meeting, Call
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Meeting status
        ///     Required
        ///     Enum: InProgress, Done
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Host hostInfo { get; set; }

        /// <summary>
        ///     Describe access rights which has participants to meeting
        ///     Required
        ///     Enum: delete, download, share
        /// </summary>
        public string[] rights { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates text summary about this meeting
        /// </summary>
        public string longSummary { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates text summary about this meeting
        /// </summary>
        public string shortSummary { get; set; }

        /// <summary>
        ///     During meeting AI team analyze code and after meeting finished generates key words used in meeting
        /// </summary>
        public string[] keywords { get; set; }

        /// <summary>
        ///     List of the participants in the meeting
        ///     Required
        /// </summary>
        public Participant[] participants { get; set; }

        /// <summary>
        ///     Recording information
        ///     Required
        /// </summary>
        public Recording[] recordings { get; set; }

        /// <summary>
        ///     Chat location
        /// </summary>
        public string chatUrl { get; set; }
    }
}