namespace RingCentral
{
    public class CallsByType
    {
        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? direct { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? fromQueue { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? parkRetrieval { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? transferred { get; set; }

        /// <summary>
        ///     Required
        ///     Format: double
        /// </summary>
        public decimal? outbound { get; set; }
    }
}