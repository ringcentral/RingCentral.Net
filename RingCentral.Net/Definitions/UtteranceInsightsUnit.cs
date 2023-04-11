namespace RingCentral
{
    public class UtteranceInsightsUnit
    {
        /// <summary>
        ///     Required
        ///     Example: Emotion
        ///     Enum: Emotion
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Required
        ///     Example: Neutral
        /// </summary>
        public string value { get; set; }

        /// <summary>
        ///     Format: float
        ///     Example: 0.97
        /// </summary>
        public decimal? confidence { get; set; }
    }
}