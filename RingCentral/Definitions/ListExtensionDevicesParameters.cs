namespace RingCentral
{
    public class ListExtensionDevicesParameters
    {
        // Pooling type of a device
        // Enum: Host, Guest, None
        public string linePooling;

        // Device feature or multiple features supported
        // Enum: Intercom, Paging, BLA
        public string feature;
    }
}