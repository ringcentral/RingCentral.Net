namespace RingCentral
{
    /// <summary>
    ///     Shipping information, according to which devices (in case of  HardPhone)
    ///     or e911 stickers (in case of  SoftPhone  and  OtherPhone ) will be delivered
    ///     to the customer
    /// </summary>
    public class ShippingInfo
    {
        /// <summary>
        ///     Order item shipping status. It is set to `Initial` when the order is submitted.
        ///     Then it is changed to `Accepted` when a distributor starts processing the order.
        ///     Finally it is changed to `Shipped` which means that the distributor has shipped the device.
        ///     Example: Shipped
        ///     Enum: Initial, Accepted, Shipped
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
        public ShippingMethodInfo method { get; set; }

        /// <summary>
        /// </summary>
        public ShippingAddressInfo address { get; set; }
    }
}