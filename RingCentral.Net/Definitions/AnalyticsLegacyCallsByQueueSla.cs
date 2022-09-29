namespace RingCentral
{
    public class AnalyticsLegacyCallsByQueueSla
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? inSla { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outOfSla { get; set; }
    }
}