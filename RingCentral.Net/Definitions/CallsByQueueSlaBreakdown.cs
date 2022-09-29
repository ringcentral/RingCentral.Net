namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by queue SLA
    /// </summary>
    public class CallsByQueueSlaBreakdown
    {
        /// <summary>
        ///     Value for InSla queue SLA
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? inSla { get; set; }

        /// <summary>
        ///     Value for OutSla queue SLA
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outOfSla { get; set; }
    }
}