namespace RingCentral
{
    /// <summary>
    ///     Meeting information
    /// </summary>
    public class BasicMeeting
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
    }
}