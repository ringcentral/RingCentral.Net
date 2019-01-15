using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UpdateMessageRequest : Serializable
    {
        // Read status of a message to be changed. Multiple values are accepted
        public string readStatus;
    }
}