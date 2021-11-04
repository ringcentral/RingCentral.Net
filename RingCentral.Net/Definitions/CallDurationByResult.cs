namespace RingCentral
{
    public class CallDurationByResult
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? completedCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? abandonedCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? voiceMailCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? connectedCallsSeconds { get; set; }
    }
}