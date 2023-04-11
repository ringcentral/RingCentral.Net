namespace RingCentral
{
    /// <summary>
    ///     Request body for operation moveParties
    /// </summary>
    public class MovePartiesRequest
    {
        /// <summary>
        /// </summary>
        public RCCInfo rcc { get; set; }

        /// <summary>
        ///     Array of parties to drop from session
        /// </summary>
        public string[] dropParties { get; set; }

        /// <summary>
        ///     RCV token for Server Based Conferencing
        /// </summary>
        public string rcvToken { get; set; }
    }
}