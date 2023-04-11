namespace RingCentral
{
    /// <summary>
    ///     Target caller info
    /// </summary>
    public class BaseCallLogToParty
    {
        /// <summary>
        ///     The dialed phone number without modifications. Returned for outbound calls and Overlay accounts
        /// </summary>
        public string dialedPhoneNumber { get; set; }
    }
}