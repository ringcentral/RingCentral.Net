using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipMentionsInfo : Serializable
    {
        // Internal identifier of a user
        public string id;
        // Type of mentions
        public string type;
        // Name of a user
        public string name;
    }
}