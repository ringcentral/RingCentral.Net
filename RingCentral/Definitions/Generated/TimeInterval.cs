using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class TimeInterval : Serializable
    {
        // Time in format hh:mm
        public string from;
        // Time in format hh:mm
        public string to;
    }
}