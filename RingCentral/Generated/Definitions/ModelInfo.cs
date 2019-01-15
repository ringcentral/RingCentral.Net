using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ModelInfo : Serializable
    {
        // Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        public string id;
        // Device name
        public string name;
        // Addons description
        public AddonInfo[] addons;
        // Device feature or multiple features supported
        public string[] features;
    }
}