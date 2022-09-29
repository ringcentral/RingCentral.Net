namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by origin
    /// </summary>
    public class CallsByOriginBreakdown
    {
        /// <summary>
        ///     Value for Internal origin
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? @internal { get; set; }

        /// <summary>
        ///     Value for External origin
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? external { get; set; }
    }
}