namespace RingCentral
{
    /// <summary>
    ///     Schedule when an answering rule should be applied
    /// </summary>
    public class ScheduleInfo
    {
        /// <summary>
        /// </summary>
        public WeeklyScheduleInfo weeklyRanges { get; set; }

        /// <summary>
        ///     Specific data ranges
        /// </summary>
        public RangesInfo[] ranges { get; set; }

        /// <summary>
        ///     The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the
        ///     corresponding method
        ///     Enum: BusinessHours, AfterHours
        /// </summary>
        public string @ref { get; set; }
    }
}