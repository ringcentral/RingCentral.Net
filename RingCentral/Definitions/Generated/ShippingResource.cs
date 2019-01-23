namespace RingCentral
{
    public class ShippingResource : Serializable
    {
        public EmergencyServiceAddressResource address;
        public MethodResource method;
        public string status;
        public string carrier;
        public string trackingNumber;
    }
}