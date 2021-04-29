namespace RingCentral
{
    // Query parameters for operation readExtensionCallQueuePresence
    public class ReadExtensionCallQueuePresenceParameters
    {
        /// <summary>
        ///     Filtering by the flag 'Allow members to change their Queue Status'. If 'true' only queues where user can change his availability status are returned
        /// </summary>
        public bool? editableMemberStatus { get; set; }
    }
}