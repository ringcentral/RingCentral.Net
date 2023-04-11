namespace RingCentral
{
    public class ConversationalInsightsUnitValues
    {
        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     Required
        ///     Example: RingCentral MVP
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 4.7
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 5.1
        /// </summary>
        public decimal? end { get; set; }
    }
}