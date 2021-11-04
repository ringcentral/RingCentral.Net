namespace RingCentral
{
    public class CallDurationByResponse
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? answeredCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? notAnsweredCallsSeconds { get; set; }
    }
}