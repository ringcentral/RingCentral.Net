using Newtonsoft.Json;

namespace RingCentral
{
    // Apple Push Notification Service Info
    public class GlipAPSInfo
    {
        /// <summary>
        ///     If the value is '1' then notification is turned on even if the application is in background
        /// </summary>
        [JsonProperty("content-available")] public long? contentAvailable;
    }
}