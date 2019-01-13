using Newtonsoft.Json;

namespace RingCentral
{
    public class CallQueueBulkAssignResource : Serializable
    {
        public string[] addedExtensionIds;
        public string[] removedExtensionIds;
    }
}