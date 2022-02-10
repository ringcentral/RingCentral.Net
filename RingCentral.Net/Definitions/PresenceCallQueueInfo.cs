namespace RingCentral
{
    /// <summary>
    ///     Call queue information
    /// </summary>
    public class PresenceCallQueueInfo
    {
        /// <summary>
        ///     Internal identifier of a call queue
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a call queue
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number of a call queue
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Flag allow members to change their queue status
        /// </summary>
        public bool? editableMemberStatus { get; set; }
    }
}