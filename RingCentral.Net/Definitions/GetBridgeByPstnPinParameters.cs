namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation getBridgeByPstnPin
    /// </summary>
    public class GetBridgeByPstnPinParameters
    {
        /// <summary>
        ///     Phone number to find a phone group for PSTN PIN. If it is not specified, then the default phone group will be used.
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Bridge hash password
        /// </summary>
        public string pw { get; set; }
    }
}