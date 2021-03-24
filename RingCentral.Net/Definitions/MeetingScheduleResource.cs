namespace RingCentral
{
    // Timing of a meeting
    public class MeetingScheduleResource
    {
        /// <summary>
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        /// Format: int32
        /// </summary>
        public long? durationInMinutes { get; set; }

        /// <summary>
        /// </summary>
        public TimezoneResource timeZone { get; set; }
    }
}