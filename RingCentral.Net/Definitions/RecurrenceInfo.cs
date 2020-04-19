namespace RingCentral
{
    public class RecurrenceInfo
    {
        /// <summary>
        /// Recurrence time frame
        /// Enum: Daily, Weekly, Monthly
        /// </summary>
        public string frequency;

        /// <summary>
        /// Reccurence interval. The supported ranges are: 1-90 for `Daily`; 1-12 for `Weekly`; 1-3 for `Monthly`
        /// </summary>
        public long? interval;

        /// <summary>
        /// Supported together with `weeklyByDay`
        /// Enum: Last, First, Second, Third, Fourth
        /// </summary>
        public string monthlyByWeek;

        /// <summary>
        /// Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string weeklyByDay;

        /// <summary>
        /// Multiple values are supported, should be specified separated by comma
        /// Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string weeklyByDays;

        /// <summary>
        /// The supported range is 1-31
        /// </summary>
        public long? monthlyByDay;

        /// <summary>
        /// Number of occurences
        /// </summary>
        public long? count;

        /// <summary>
        /// Meeting expiration datetime
        /// </summary>
        public string until;
    }
}