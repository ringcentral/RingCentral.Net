using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PatchOperation : Serializable
    {
        // Enum: add, replace, remove
        public string op;
        public string path;
        // corresponding 'value' of that field specified by 'path'
        public string value;
    }
}