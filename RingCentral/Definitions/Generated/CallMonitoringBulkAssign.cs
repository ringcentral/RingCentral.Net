namespace RingCentral
{
    public class CallMonitoringBulkAssign : Serializable
    {
        public CallMonitoringExtensionUpdate[] addedExtensions;
        public CallMonitoringExtensionUpdate[] removedExtensions;
        public CallMonitoringExtensionUpdate[] updatedExtensions;
    }
}