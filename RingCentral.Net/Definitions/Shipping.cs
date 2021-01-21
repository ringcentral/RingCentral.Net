namespace RingCentral
{
    // Shipping information, according to which devices (in case of HardPhone ) or e911 stickers (in case of SoftPhone and OtherPhone ) will be delivered to the customer
    public class Shipping
    {
        /// <summary>
        /// </summary>
        public DeviceEmergencyServiceAddressResource address { get; set; }

        /// <summary>
        /// </summary>
        public MethodResource method { get; set; }

        /// <summary>
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public string carrier { get; set; }

        /// <summary>
        /// </summary>
        public string trackingNumber { get; set; }
    }
}