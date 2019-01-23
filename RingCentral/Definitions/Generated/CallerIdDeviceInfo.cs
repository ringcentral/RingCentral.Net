namespace RingCentral
{
    public class CallerIdDeviceInfo : Serializable
    {
        // Internal identifier of a device
        public string id;
        // Link to a device resource
        public string uri;
        // Name of a device
        public string phoneNumber;
    }
}