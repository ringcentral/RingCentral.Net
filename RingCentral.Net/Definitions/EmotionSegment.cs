namespace RingCentral
{
    public class EmotionSegment
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
        ///     Example: Neutral
        ///     Enum: Anger, Excitement, Frustration, Joy, Sadness, Neutral
        /// </summary>
        public string emotion { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }
    }
}