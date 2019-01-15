using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class NotificationInfo : Serializable
    {
        // Alert information
        public AlertInfo alert;
        // Number of incoming messages
        public string badge;
        // Message sound
        public string sound;
        // Content availability
        [JsonProperty("content-available")]
        public string contentAvailable;
        // Category of a message
        public string category;
    }
}