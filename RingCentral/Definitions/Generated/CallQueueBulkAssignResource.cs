using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallQueueBulkAssignResource : Serializable
    {
        public string[] addedExtensionIds;
        public string[] removedExtensionIds;
    }
}