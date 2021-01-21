using Newtonsoft.Json;

namespace RingCentral
{
    // Information on a notification
    public class NotificationInfo
    {
        /// <summary>
        /// </summary>
        public AlertInfo alert { get; set; }

        /// <summary>
        /// Number of incoming messages
        /// </summary>
        public string badge { get; set; }

        /// <summary>
        /// Message sound
        /// </summary>
        public string sound { get; set; }

        /// <summary>
        /// Content availability
        /// </summary>
        [JsonProperty("content-available")] public string contentAvailable;

        /// <summary>
        /// Category of a message
        /// </summary>
        public string category { get; set; }
    }
}