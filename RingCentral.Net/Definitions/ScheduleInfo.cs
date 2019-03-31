namespace RingCentral
{
    public class ScheduleInfo
    {
        /// <summary>
        /// Weekly schedule
        /// </summary>
        public WeeklyScheduleInfo weeklyRanges;

        /// <summary>
        /// Specific data ranges
        /// </summary>
        public RangesInfo[] ranges;

        /// <summary>
        /// The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
        /// Enum: BusinessHours, AfterHours
        /// </summary>
        public string @ref;
    }
}