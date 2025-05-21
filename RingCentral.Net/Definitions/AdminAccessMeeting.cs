namespace RingCentral
{
    /// <summary>
    ///     Meeting information
    /// </summary>
    public class AdminAccessMeeting
    {
        /// <summary>
        ///     Meeting id
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Short bridge id
        ///     Required
        /// </summary>
        public string shortId { get; set; }

        /// <summary>
        ///     Bridge id
        ///     Required
        /// </summary>
        public string bridgeId { get; set; }

        /// <summary>
        ///     Start time ISO 8601
        ///     Required
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Meeting name
        ///     Required
        /// </summary>
        public string displayName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Host hostInfo { get; set; }

        /// <summary>
        ///     Meeting duration in seconds
        ///     Required
        ///     Format: int32
        ///     Example: 36
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     List of the participants in the meeting
        ///     Required
        /// </summary>
        public BasicParticipant[] participants { get; set; }

        /// <summary>
        ///     Public chat txt file for the meeting
        /// </summary>
        public string chatContentUri { get; set; }
    }
}