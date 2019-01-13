using Newtonsoft.Json;

namespace RingCentral
{
    public class MethodInfo : Serializable
    {
        // Method identifier. The default value is 1 (Ground)
        public string id;
        // Method name, corresponding to the identifier
        public string name;
    }
}