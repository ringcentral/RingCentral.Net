using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallRecording : Serializable
    {
        // Internal identifier of a call recording
        public string id;
        // Call recording status
        public bool? active;
    }
}