using Newtonsoft.Json;

namespace RingCentral
{
    public class APSInfo
    {
        /* If the value is '1' then notification is turned on even if the application is in background */
        // Default: 1
        [JsonProperty("content-available")] public long? contentAvailable;
    }
}