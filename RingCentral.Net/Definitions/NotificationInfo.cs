using Newtonsoft.Json;

namespace RingCentral
{
    /// <summary>
    ///     Information on a notification
    /// </summary>
    public class NotificationInfo
    {
        /// <summary>
        ///     Content availability
        /// </summary>
        [JsonProperty("content-available")] public string contentAvailable;

        /// <summary>
        /// </summary>
        public AlertInfo alert { get; set; }

        /// <summary>
        ///     Number of incoming messages
        /// </summary>
        public string badge { get; set; }

        /// <summary>
        ///     Message sound
        /// </summary>
        public string sound { get; set; }

        /// <summary>
        ///     Category of a message
        /// </summary>
        public string category { get; set; }
    }
}