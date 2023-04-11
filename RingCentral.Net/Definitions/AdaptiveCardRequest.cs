namespace RingCentral
{
    public class AdaptiveCardRequest
    {
        /// <summary>
        ///     Type of attachment. This field is mandatory and filled on server side -
        ///     will be ignored if set in request body
        ///     Required
        ///     Enum: AdaptiveCard
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Version. This field is mandatory and filled on server side -
        ///     will be ignored if set in request body
        ///     Required
        /// </summary>
        public string version { get; set; }

        /// <summary>
        ///     List of adaptive cards with the detailed information
        /// </summary>
        public AdaptiveCardInfoRequest[] body { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardAction[] actions { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardSelectAction selectAction { get; set; }

        /// <summary>
        /// </summary>
        public string fallbackText { get; set; }

        /// <summary>
        ///     Specifies a background image oa a card. Acceptable formats are PNG, JPEG, and GIF
        /// </summary>
        public BackgroundImage backgroundImage { get; set; }

        /// <summary>
        ///     Specifies the minimum height of the card in pixels
        ///     Example: 50px
        /// </summary>
        public string minHeight { get; set; }

        /// <summary>
        ///     Specifies what should be spoken for this entire card. This is simple text or SSML fragment
        /// </summary>
        public string speak { get; set; }

        /// <summary>
        ///     The 2-letter ISO-639-1 language used in the card. Used to localize any date/time functions
        ///     Enum: en, fr, es
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