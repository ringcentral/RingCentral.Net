namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by direction
    /// </summary>
    public class CallsByDirectionBreakdown
    {
        /// <summary>
        ///     Value for Inbound direction
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? inbound { get; set; }

        /// <summary>
        ///     Value for Outbound direction
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outbound { get; set; }
    }
}