namespace RingCentral
{
    public class WordSegment
    {
        /// <summary>
        ///     Example: JohnDoe
        /// </summary>
        public string speakerId { get; set; }

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
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }

        /// <summary>
        ///     Required
        ///     Example: hello
        /// </summary>
        public string word { get; set; }
    }
}