namespace RingCentral
{
    public class NotificationDeliveryMode : Serializable
    {
        public string transportType;
        public bool? encryption;
        public string address;
        public string subscriberKey;
        public string secretKey;
        public string encryptionAlgorithm;
        public string encryptionKey;
    }
}
