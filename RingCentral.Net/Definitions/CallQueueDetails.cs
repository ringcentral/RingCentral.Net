namespace RingCentral
{
    public class CallQueueDetails
    {
        /// <summary>
        ///     Link to a call queue
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a call queue
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension number of a call queue
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Name of a call queue
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Group extension status
        ///     Enum: Enabled, Disabled, NotActivated
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Indicates whether it is an emergency call queue extension or not
        ///     Enum: Emergency
        /// </summary>
        public string subType { get; set; }

        /// <summary>
        /// </summary>
        public SiteBasicInfo site { get; set; }

        /// <summary>
        /// </summary>
        public CallQueueServiceLevelSettings serviceLevelSettings { get; set; }

        /// <summary>
        ///     Allows members to change their queue status
        /// </summary>
        public bool? editableMemberStatus { get; set; }

        /// <summary>
        ///     Alert timer or pickup setting. Delay time in seconds before call queue group members are notified when calls are
        ///     queued
        ///     Format: int32
        ///     Enum: 5, 10, 15, 20, 30, 45, 60, 120, 180, 240, 300, 360, 420, 480, 540, 600
        /// </summary>
        public long? alertTimer { get; set; }
    }
}