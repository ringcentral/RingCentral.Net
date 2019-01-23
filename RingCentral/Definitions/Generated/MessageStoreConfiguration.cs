namespace RingCentral
{
    public class MessageStoreConfiguration : Serializable
    {
        // Retention policy setting, specifying how long to keep messages; the supported value range is 7-90 days
        public long? retentionPeriod;
    }
}