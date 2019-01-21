using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class BulkAssignItem : Serializable
    {
        public string departmentId;
        public string[] addedExtensionIds;
        public string[] removedExtensionIds;
    }
}