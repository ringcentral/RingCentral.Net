namespace RingCentral
{
    public class WordTimingsUnit
    {
        /// <summary>
        ///     Format: float
        ///     Example: 0.3
        /// </summary>
        public decimal? start { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 5.1
        /// </summary>
        public decimal? end { get; set; }

        /// <summary>
        ///     Example: Hello
        /// </summary>
        public string word { get; set; }
    }
}