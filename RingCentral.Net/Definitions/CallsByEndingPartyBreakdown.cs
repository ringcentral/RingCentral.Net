namespace RingCentral
{
    public class CallsByEndingPartyBreakdown
    {
        /// <summary>
        ///     Value for Caller ending party
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? caller { get; set; }

        /// <summary>
        ///     Value for Callee ending party
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? callee { get; set; }

        /// <summary>
        ///     Value for System ending party
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? system { get; set; }
    }
}