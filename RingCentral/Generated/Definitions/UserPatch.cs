using Newtonsoft.Json;

namespace RingCentral
{
    public class UserPatch : Serializable
    {
        // patch operations list
        public PatchOperation[] Operations;
        public string[] schemas;
    }
}