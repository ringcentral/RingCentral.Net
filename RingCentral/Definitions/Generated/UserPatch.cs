namespace RingCentral
{
    public class UserPatch : Serializable
    {
        // patch operations list
        public PatchOperation[] Operations; // Required
        public string[] schemas; // Required
    }
}