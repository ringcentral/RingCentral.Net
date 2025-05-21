namespace RingCentral
{
    /// <summary>
    ///     Meeting information
    /// </summary>
    public class CloudRecording
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

        /// <summary>
        ///     Meeting duration in seconds
        ///     Format: int32
        ///     Example: 36
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     Link to the recording file. Not used anymore by Web team
        ///     Required
        /// </summary>
        public string mediaLink { get; set; }

        /// <summary>
        ///     Encrypted link to the recording file
        ///     Required
        /// </summary>
        public string url { get; set; }

        /// <summary>
        ///     Date after which recording will be deleted
        /// </summary>
        public string expiresIn { get; set; }
    }
}