using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MethodInfo : Serializable
    {
        // Method identifier. The default value is 1 (Ground)
        // Enum: 1, 2, 3
        public string id;
        // Method name, corresponding to the identifier
        // Enum: Ground, 2 Day, Overnight
        public string name;
    }
}