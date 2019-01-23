namespace RingCentral
{
    public class BulkSupported : Serializable
    {
        public long? maxOperations;
        public long? maxPayloadSize;
        public bool? supported;
    }
}