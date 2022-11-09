namespace RingCentral
{
    public class AdaptiveCardRequest
    {
        /// <summary>
        /// </summary>
        public AdaptiveCardRequestBody[] body { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardRequestActions[] actions { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardRequestSelectAction selectAction { get; set; }

        /// <summary>
        /// </summary>
        public string fallbackText { get; set; }

        /// <summary>
        /// </summary>
        public BackgroundImage backgroundImage { get; set; }

        /// <summary>
        /// </summary>
        public string minHeight { get; set; }

        /// <summary>
        /// </summary>
        public string speak { get; set; }

        /// <summary>
        /// </summary>
        public string lang { get; set; }

        /// <summary>
        ///     Defines how the content should be aligned vertically within the container. Only relevant for fixed-height cards, or
        ///     cards with a `minHeight` specified
        ///     Enum: top, center, bottom
        /// </summary>
        public string verticalContentAlignment { get; set; }
    }
}