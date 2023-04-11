namespace RingCentral
{
    /// <summary>
    ///     Sender/initiator caller info
    /// </summary>
    public class BaseCallLogFromParty
    {
        /// <summary>
        ///     The dialer phone number without modifications. Returned for inbound calls and Overlay accounts
        /// </summary>
        public string dialerPhoneNumber { get; set; }
    }
}