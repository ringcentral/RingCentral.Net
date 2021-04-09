namespace RingCentral
{
    public class CallQueueDetails
    {
        /// <summary>
        ///     Internal identifier of a call queue
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Call queue name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Call queue extension number
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Call queue status
        ///     Enum: Enabled, Disabled, NotActivated
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueServiceLevelSettings serviceLevelSettings { get; set; }

        /// <summary>
        ///     Allows members to change their queue status
        /// </summary>
        public bool? editableMemberStatus { get; set; }
    }
}