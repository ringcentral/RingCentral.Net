namespace RingCentral
{
    public class BulkAccountCallRecordingsResource : Serializable
    {
        public CallRecordingExtensionResource addedExtensions;
        public CallRecordingExtensionResource updatedExtensions;
        public CallRecordingExtensionResource removedExtensions;
    }
}