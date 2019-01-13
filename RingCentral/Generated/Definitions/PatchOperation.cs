using Newtonsoft.Json;

namespace RingCentral
{
    public class PatchOperation : Serializable
    {
        public string op;
        public string path;
        // corresponding 'value' of that field specified by 'path'
        public string value;
    }
}