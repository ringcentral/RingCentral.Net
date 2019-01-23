using Newtonsoft.Json;

namespace RingCentral
{
    public class PatchOperation : Serializable
    {
        // Enum: add, replace, remove
        public string op; // Required
        public string path;
        // corresponding 'value' of that field specified by 'path'
        public string value;
    }
}