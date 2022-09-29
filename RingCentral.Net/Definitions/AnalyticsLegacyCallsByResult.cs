namespace RingCentral
{
    public class AnalyticsLegacyCallsByResult
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? completed { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? abandoned { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? voicemail { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? missed { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? accepted { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? unknown { get; set; }
    }
}