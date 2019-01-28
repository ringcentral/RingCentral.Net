namespace RingCentral
{
    public class PatchOperation
    {
        // Enum: add, replace, remove
        public string op; // Required

        public string path;

        // corresponding 'value' of that field specified by 'path'
        public string value;
    }
}