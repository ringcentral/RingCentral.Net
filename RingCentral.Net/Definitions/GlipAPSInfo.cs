using Newtonsoft.Json;

namespace RingCentral
{
    /// <summary>
    ///     Apple Push Notification Service Info
    /// </summary>
    public class GlipAPSInfo
    {
        /// <summary>
        ///     If the value is '1' then notification is turned on even if the application is in background
        /// </summary>
        [JsonProperty("content-available")] public long? contentAvailable;
    }
}