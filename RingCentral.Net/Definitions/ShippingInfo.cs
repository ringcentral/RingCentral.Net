namespace RingCentral
{
    // Shipping information, according to which devices (in case of  HardPhone ) or e911 stickers (in case of  SoftPhone  and  OtherPhone ) will be delivered to the customer
    public class ShippingInfo
    {
        /// <summary>
        ///     Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally the status is changed to 'Shipped' which means that distributor shipped the device.
        ///     Enum: Initial, Accepted, Shipped, Won't ship
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Shipping carrier name. Appears only if the device status is 'Shipped'
        /// </summary>
        public string carrier { get; set; }

        /// <summary>
        ///     Carrier-specific tracking number. Appears only if the device status is 'Shipped'
        /// </summary>
        public string trackingNumber { get; set; }

        /// <summary>
        /// </summary>
        public MethodInfo method { get; set; }

        /// <summary>
        /// </summary>
        public ShippingAddressInfo address { get; set; }
    }
}