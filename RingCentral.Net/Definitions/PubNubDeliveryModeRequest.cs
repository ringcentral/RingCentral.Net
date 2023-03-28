namespace RingCentral
{
    public class PubNubDeliveryModeRequest
    {
        /// <summary>
        ///     Notifications transport type
        ///     Required
        ///     Enum: PubNub
        /// </summary>
        public string transportType { get; set; }

        /// <summary>
        ///     Optional. Specifies if notification messages will be encrypted
        ///     or not. Please note that for some event filters (e.g. presence) encryption is mandatory and
        ///     `false` value provided by caller will be ignored.
        /// </summary>
        public bool? encryption { get; set; }
    }
}