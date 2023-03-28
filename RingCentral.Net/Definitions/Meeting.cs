namespace RingCentral
{
    /// <summary>
    ///     Meeting information
    /// </summary>
    public class Meeting
    {
        /// <summary>
        ///     call id
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     bridge id
        ///     Required
        /// </summary>
        public string bridgeId { get; set; }

        /// <summary>
        ///     short bridge id
        ///     Required
        /// </summary>
        public string shortId { get; set; }

        /// <summary>
        ///     start time ISO 8601
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     duration second
        ///     Format: int32
        ///     Example: 36
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     meetings name
        ///     Required
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     meeting type
        ///     Required
        ///     Enum: Meeting, Call
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     meeting status
        ///     Required
        ///     Enum: InProgress, Done
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Host hostInfo { get; set; }

        /// <summary>
        ///     chat id
        /// </summary>
        public string chatId { get; set; }

        /// <summary>
        ///     participants list
        ///     Required
        /// </summary>
        public Participant[] participants { get; set; }

        /// <summary>
        ///     recording information
        /// </summary>
        public Recording[] recordings { get; set; }

        /// <summary>
        ///     chat location
        /// </summary>
        public string chatUrl { get; set; }
    }
}