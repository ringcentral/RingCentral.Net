namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by queue hours
    /// </summary>
    public class CallsByQueueHoursBreakdown
    {
        /// <summary>
        ///     Value for BusinessHours queue hours
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? businessHours { get; set; }

        /// <summary>
        ///     Value for AfterHours queue hours
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? afterHours { get; set; }
    }
}