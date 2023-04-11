using Newtonsoft.Json;

namespace RingCentral
{
    public class AdaptiveCardInfo
    {
        /// <summary>
        ///     Internal identifier of an adaptive card
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Adaptive Card creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        ///     Schema of an adaptive card
        ///     Format: uri
        /// </summary>
        [JsonProperty("$schema")]
        public string schema { get; set; }

        /// <summary>
        ///     Enum: AdaptiveCard
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Version of an adaptive card
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardCreator creator { get; set; }

        /// <summary>
        ///     Chat IDs where an adaptive card is posted or shared.
        /// </summary>
        public string[] chatIds { get; set; }

        /// <summary>
        ///     List of card elements to show in the primary card region
        /// </summary>
        public AdaptiveCardInfoRequest[] body { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardAction[] actions { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardSelectAction selectAction { get; set; }

        /// <summary>
        ///     Text shown when the client doesn't support the version specified (may contain markdown)
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