using Newtonsoft.Json;

namespace RingCentral
{
    public class AdaptiveCardShortInfo
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
        /// </summary>
        [JsonProperty("$schema")]
        public string schema { get; set; }

        /// <summary>
        ///     Enum: AdaptiveCard
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Version of an adaptive card. Filled on server-side
        /// </summary>
        public string version { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardCreator creator { get; set; }

        /// <summary>
        ///     Chat IDs where an adaptive card is posted or shared.
        /// </summary>
        public string[] chatIds { get; set; }
    }
}