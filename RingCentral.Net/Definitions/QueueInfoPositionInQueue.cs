namespace RingCentral
{
    public class QueueInfoPositionInQueue
    {
        /// <summary>
        ///     Controls when position-in-queue announcement is played.
        ///     `OnPositionChange` - only if the caller's position changed since the last announcement.
        ///     Default: EveryInterval
        ///     Enum: EveryInterval, OnPositionChange
        /// </summary>
        public string playbackFrequency { get; set; }
    }
}