using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallRecordingCustomGreetingData : Serializable
    {
        // Link to a custom company greeting
        public string uri;
        // Internal identifier of a custom company greeting
        public string id;
    }
}