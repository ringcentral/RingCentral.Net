using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MethodInfo : Serializable
    {
        // Method identifier. The default value is 1 (Ground)
        public string id;
        // Method name, corresponding to the identifier
        public string name;
    }
}