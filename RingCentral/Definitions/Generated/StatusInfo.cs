using Newtonsoft.Json;

namespace RingCentral
{
    public class StatusInfo : Serializable
    {
        public string reason;
        public string till;
        public string comment;
    }
}