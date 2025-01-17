namespace RingCentral
{
    public class HighlightsInsightUnit
    {
        /// <summary>
        ///     Participant ID
        ///     Required
        ///     Example: p-32423
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     Value of the insight
        ///     Required
        ///     Example: conversational insights text
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Start time of the insight (in sec)
        ///     Required
        ///     Format: float
        ///     Example: 1.2
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     End time of the insight (in sec)
        ///     Required
        ///     Format: float
        ///     Example: 4.2
        /// </summary>
        public decimal? end { get; set; }
    }
}