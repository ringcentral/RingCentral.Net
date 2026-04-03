namespace RingCentral
{
    public class BulkAccountCallRecordingsResource
    {
        /// <summary>
        /// </summary>
        public CallRecordingExtensionResource[] addedExtensions { get; set; }

        /// <summary>
        /// </summary>
        public CallRecordingExtensionResource[] updatedExtensions { get; set; }

        /// <summary>
        /// </summary>
        public CallRecordingExtensionResource[] removedExtensions { get; set; }
    }
}