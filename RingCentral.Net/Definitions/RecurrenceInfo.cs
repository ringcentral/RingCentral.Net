namespace RingCentral
{
    public class RecurrenceInfo
    {
        /// <summary>
        ///     Recurrence time frame
        ///     Enum: Daily, Weekly, Monthly
        /// </summary>
        public string frequency { get; set; }

        /// <summary>
        ///     Recurrence interval. The supported ranges are: 1-90 for `Daily`;
        ///     1-12 for `Weekly`; 1-3 for `Monthly`
        ///     Format: int32
        /// </summary>
        public long? interval { get; set; }

        /// <summary>
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string[] weeklyByDays { get; set; }

        /// <summary>
        ///     The supported range is 1-31
        ///     Format: int32
        /// </summary>
        public long? monthlyByDay { get; set; }

        /// <summary>
        ///     Supported together with `weeklyByDay`
        ///     Enum: Last, First, Second, Third, Fourth
        /// </summary>
        public string monthlyByWeek { get; set; }

        /// <summary>
        ///     This field is used only if you're scheduling a recurring meeting of type `3` to state a specific day in a week when
        ///     the monthly meeting should recur; it works together with `MonthlyByWeek` field. The values are: 1 - Sunday; 2 -
        ///     Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string monthlyByWeekDay { get; set; }

        /// <summary>
        ///     Number of meeting occurrences
        ///     Format: int32
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        ///     Meeting expiration date-time
        /// </summary>
        public string until { get; set; }
    }
}