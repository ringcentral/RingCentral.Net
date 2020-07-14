namespace RingCentral
{
    public class NotificationDeliveryModeRequest
    {
        /// <summary>
        /// Notifications transportation provider name
        /// Enum: PubNub, WebHook, RC/APNS, RC/GCM, WebSocket
        /// </summary>
        public string transportType;

        /// <summary>
        /// Mandatory for 'WebHook' transport type, URL of a consumer service (cannot be changed during subscription update)
        /// </summary>
        public string address;

        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'
        /// </summary>
        public bool? encryption;

        /// <summary>
        /// Name of a certificate. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string certificateName;

        /// <summary>
        /// Identifier of a registration. Supported for 'RC/APNS' and 'RC/GCM' transport types
        /// </summary>
        public string registrationId;

        /// <summary>
        /// Verification key of a subscription ensuring data security. Supported for 'Webhook' transport type
        /// </summary>
        public string verificationToken;
    }
}