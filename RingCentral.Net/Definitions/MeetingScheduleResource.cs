namespace RingCentral
{
    /// <summary>
    ///     Timing of a meeting
    /// </summary>
    public class MeetingScheduleResource
    {
        /// <summary>
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? durationInMinutes { get; set; }

        /// <summary>
        /// </summary>
        public MeetingsTimezoneResource timeZone { get; set; }
    }
}