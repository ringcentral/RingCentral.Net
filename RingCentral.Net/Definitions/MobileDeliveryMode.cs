namespace RingCentral
{
    public class MobileDeliveryMode
    {
        /// <summary>
        ///     Notifications transport type
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

        /// <summary>
        ///     Specifies if notification messages will be encrypted or not.
        ///     Required
        ///     Enum: false
        /// </summary>
        public bool? encryption { get; set; }
    }
}