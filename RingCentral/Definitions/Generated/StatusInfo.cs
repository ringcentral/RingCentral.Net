using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class StatusInfo : Serializable
    {
        public string reason;
        public string till;
        public string comment;
    }
}