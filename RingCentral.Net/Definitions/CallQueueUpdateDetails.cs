namespace RingCentral
{
    public class CallQueueUpdateDetails
    {
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