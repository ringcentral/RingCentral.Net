namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by response
    /// </summary>
    public class CallsByResponseBreakdown
    {
        /// <summary>
        ///     Value for Answered response
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? answered { get; set; }

        /// <summary>
        ///     Value for NotAnswered response
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? notAnswered { get; set; }

        /// <summary>
        ///     Value for Connected response
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? connected { get; set; }

        /// <summary>
        ///     Value for NotConnected response
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? notConnected { get; set; }
    }
}