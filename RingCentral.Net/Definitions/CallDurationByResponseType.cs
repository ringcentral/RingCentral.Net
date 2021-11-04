namespace RingCentral
{
    public class CallDurationByResponseType
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? inboundDirectSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? parkRetrievalsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? queueCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? transferredCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? missedCallsSeconds { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? acceptedCallsSeconds { get; set; }
    }
}