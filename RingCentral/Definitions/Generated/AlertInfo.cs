using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AlertInfo : Serializable
    {
        // Title of a message
        public string title;
        // Message Description
        public string body;
    }
}