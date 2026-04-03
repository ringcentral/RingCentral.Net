namespace RingCentral
{
    public class SummaryTimingsUnit
    {
        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     Required
        ///     Example: This meeting is focussed on rise of on demand marketplaces, online marketplaces and regulated services
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 0.3
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 3600.1
        /// </summary>
        public decimal? end { get; set; }
    }
}