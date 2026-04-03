namespace RingCentral
{
    public class SummaryUnit
    {
        /// <summary>
        ///     Required
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

        /// <summary>
        ///     Required
        ///     Example: Hello! This is John.
        /// </summary>
        public string text { get; set; }

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
    }
}