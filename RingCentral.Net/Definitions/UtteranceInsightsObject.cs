namespace RingCentral
{
    public class UtteranceInsightsObject
    {
        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 0.3
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     Required
        ///     Format: float
        ///     Example: 5.1
        /// </summary>
        public decimal? end { get; set; }

        /// <summary>
        ///     Required
        ///     Example: Hello! This is John.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        /// </summary>
        public UtteranceInsightsUnit[] insights { get; set; }
    }
}