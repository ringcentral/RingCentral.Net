namespace RingCentral
{
    /// <summary>
    ///     Sender/initiator caller information
    /// </summary>
    public class BaseCallLogFromParty
    {
        /// <summary>
        ///     Dialer phone number without any format modifications. Returned for inbound calls
        /// </summary>
        public string dialerPhoneNumber { get; set; }
    }
}