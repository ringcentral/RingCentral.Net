using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CallMonitoringBulkAssign : Serializable
    {
        public CallMonitoringExtensionUpdate[] addedExtensions;
        public CallMonitoringExtensionUpdate[] removedExtensions;
        public CallMonitoringExtensionUpdate[] updatedExtensions;
    }
}