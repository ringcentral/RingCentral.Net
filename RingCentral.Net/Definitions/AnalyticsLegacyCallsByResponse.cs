namespace RingCentral
{
    public class AnalyticsLegacyCallsByResponse
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