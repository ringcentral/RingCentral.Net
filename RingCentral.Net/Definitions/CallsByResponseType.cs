namespace RingCentral
{
    public class CallsByResponseType
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? inboundDirect { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? parkRetrieval { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? queueCalls { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? transferredCalls { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? missed { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? accepted { get; set; }
    }
}