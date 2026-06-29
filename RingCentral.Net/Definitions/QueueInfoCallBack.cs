namespace RingCentral
{
    public class QueueInfoCallBack
    {
        /// <summary>
        ///     Additional announcements appended to the base callback confirmation.
        ///     Empty array means no additional announcements.
        ///     Default: 
        ///     Enum: PositionInQueue, EstimatedWaitTime
        /// </summary>
        public string[] confirmationAnnouncements { get; set; }
    }
}