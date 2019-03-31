using Newtonsoft.Json;

namespace RingCentral
{
    public class NotificationInfo
    {
        /// <summary>
        /// Alert information
        /// </summary>
        public AlertInfo alert;

        /// <summary>
        /// Number of incoming messages
        /// </summary>
        public string badge;

        /// <summary>
        /// Message sound
        /// </summary>
        public string sound;

        /// <summary>
        /// Content availability
        /// </summary>
        [JsonProperty("content-available")] public string contentAvailable;

        /// <summary>
        /// Category of a message
        /// </summary>
        public string category;
    }
}