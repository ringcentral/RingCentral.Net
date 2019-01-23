namespace RingCentral
{
    public class ShippingInfo : Serializable
    {
        // Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.
        // Enum: Initial, Accepted, Shipped
        public string status;
        // Shipping carrier name. Appears only if the device status is 'Shipped'
        public string carrier;
        // Carrier-specific tracking number. Appears only if the device status is 'Shipped'
        public string trackingNumber;
        // Shipping method information
        public MethodInfo method; // Required
        // Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses
        public ShippingAddressInfo address; // Required
    }
}