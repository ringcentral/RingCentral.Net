namespace RingCentral
{
    public class CallsByResponse
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? answered { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? notAnswered { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? connected { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? notConnected { get; set; }
    }
}