namespace RingCentral
{
    public class CallMonitoringBulkAssign
    {
        /// <summary>
        /// </summary>
        public CallMonitoringExtensionInfo[] addedExtensions { get; set; }

        /// <summary>
        /// </summary>
        public CallMonitoringExtensionInfo[] updatedExtensions { get; set; }

        /// <summary>
        /// </summary>
        public CallMonitoringExtensionInfo[] removedExtensions { get; set; }
    }
}