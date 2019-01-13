using Newtonsoft.Json;

namespace RingCentral
{
    public class BulkAssignItem : Serializable
    {
        public string departmentId;
        public string[] addedExtensionIds;
        public string[] removedExtensionIds;
    }
}