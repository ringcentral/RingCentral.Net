namespace RingCentral
{
    public class DeviceInfoRequest : Serializable
    {
        // Device unique identifier, retrieved on previous session (if any)
        public string id;

        // For iOS devices only Certificate name (used by iOS applications for APNS subscription)
        public string appExternalId;

        // For SoftPhone only Computer name
        public string computerName;
    }
}