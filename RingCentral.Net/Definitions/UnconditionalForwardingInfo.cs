namespace RingCentral
{
    /// <summary>
    ///     Unconditional forwarding parameters.
    ///     Returned if 'UnconditionalForwarding' value is specified for the `callHandlingAction` parameter
    /// </summary>
    public class UnconditionalForwardingInfo
    {
        /// <summary>
        ///     Phone number to which the call is forwarded. In addition to
        ///     common e.164 format, the following number patterns are supported: 11xxxxxxxxxxx,
        ///     444xxxxxxxxxxx, 616xxxxxxxxxxx, 1700yyyy; where xxxxxxxxxxx is a phone number in
        ///     e.164 format (without '+' sign) and yyyy is an external short extension number.
        ///     Max number of digits is 15
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Event that initiates forwarding to the specified phone number
        ///     Enum: HoldTimeExpiration, MaxCallers, NoAnswer
        /// </summary>
        public string action { get; set; }
    }
}