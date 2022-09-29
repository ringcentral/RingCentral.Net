namespace RingCentral
{
    /// <summary>
    ///     Allows more granular control over time included in the report
    /// </summary>
    public class AnalyticsLegacyPerformanceCallsAdvancedTimeSettings
    {
        /// <summary>
        ///     Name of the timezone that will be used for `includeDays` and `includeHours` filters. For example
        ///     'America/Los_Angeles', 'Europe/Moscow'. See also *[Time Zones](https://www.iana.org/time-zones)*
        ///     Required
        /// </summary>
        public string timeZone { get; set; }

        /// <summary>
        ///     Days of the week for which the report is calculated
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string[] includeDays { get; set; }

        /// <summary>
        ///     Hours of the day for which the report is calculated
        /// </summary>
        public AnalyticsLegacyPerformanceCallsTimeInterval[] includeHours { get; set; }
    }
}