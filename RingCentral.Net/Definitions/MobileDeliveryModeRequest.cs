namespace RingCentral
{
    public class MobileDeliveryModeRequest
    {
        /// <summary>
        ///     The transport type for this subscription
        ///     Required
        ///     Enum: RC/APNS, RC/GCM
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     Certificate name for mobile notification transports
        ///     Required
        /// </summary>
        public string certificateName { get; set; }

        /// <summary>
        ///     Device instance ID for mobile notification transports
        ///     Required
        ///     Example: 38b062ae-85f8-4dcc-8734-04d3f7393d42
        /// </summary>
        public string registrationId { get; set; }
    }
}