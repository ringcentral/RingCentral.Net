namespace RingCentral
{
    /// <summary>
    ///     Result breakdown by type
    /// </summary>
    public class CallsByTypeBreakdown
    {
        /// <summary>
        ///     Value for Direct type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? direct { get; set; }

        /// <summary>
        ///     Value for FromQueue type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? fromQueue { get; set; }

        /// <summary>
        ///     Value for ParkRetrieval type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? parkRetrieval { get; set; }

        /// <summary>
        ///     Value for Transferred type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? transferred { get; set; }

        /// <summary>
        ///     Value for Outbound type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outbound { get; set; }

        /// <summary>
        ///     Value for Overflow type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? overflow { get; set; }

        /// <summary>
        ///     Value for QueueCallPickup type
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? queueCallPickup { get; set; }
    }
}