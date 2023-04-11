namespace RingCentral
{
    public class SBCMoveToRCV
    {
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