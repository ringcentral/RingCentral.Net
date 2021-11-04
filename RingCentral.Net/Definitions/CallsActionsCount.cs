namespace RingCentral
{
    // Calls actions count
    public class CallsActionsCount
    {
        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? parksOn { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? parksOff { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? holdsOn { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? holdsOff { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? blindTransfer { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? warmTransfer { get; set; }
    }
}