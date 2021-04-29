using Newtonsoft.Json;

namespace RingCentral
{
    // APS (Apple Push Service) information/ priority data
    public class APSInfo
    {
        /// <summary>
        ///     If the value is '1' then notification is turned on even if the application is in background
        /// </summary>
        [JsonProperty("content-available")] public long? contentAvailable;
    }
}