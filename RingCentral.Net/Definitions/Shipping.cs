namespace RingCentral
{
    // Shipping information, according to which devices (in case of HardPhone ) or e911 stickers (in case of SoftPhone and OtherPhone ) will be delivered to the customer
    public class Shipping
    {
        /// <summary>
        /// </summary>
        public DeviceEmergencyServiceAddressResource address;

        /// <summary>
        /// </summary>
        public MethodResource method;

        /// <summary>
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public string carrier;

        /// <summary>
        /// </summary>
        public string trackingNumber;
    }
}