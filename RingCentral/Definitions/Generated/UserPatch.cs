namespace RingCentral
{
    public class UserPatch
    {
        // patch operations list
        public PatchOperation[] Operations; // Required
        public string[] schemas; // Required
    }
}