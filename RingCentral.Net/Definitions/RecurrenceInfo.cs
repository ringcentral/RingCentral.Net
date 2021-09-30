namespace RingCentral
{
    // Meeting recurrence information
    public class RecurrenceInfo
    {
        /// <summary>
        ///     Recurrence time frame
        ///     Enum: Daily, Weekly, Monthly
        /// </summary>
        public string frequency { get; set; }

        /// <summary>
        ///     Reccurence interval. The supported ranges are: 1-90 for `Daily`; 1-12 for `Weekly`; 1-3 for `Monthly`
        /// </summary>
        public long? interval { get; set; }

        /// <summary>
        ///     Supported together with `weeklyByDay`
        ///     Enum: Last, First, Second, Third, Fourth
        /// </summary>
        public string monthlyByWeek { get; set; }

        /// <summary>
        ///     This field is used only if you're scheduling a recurring meeting of type `3` to state which day in a month the
        ///     meeting should recur. The value range is 1 - 31. For instance, if the meeting should recur each month on 23rd,
        ///     provide `23` as the value of this field and `1` as the value of the recurrence `interval` field. And if the meeting
        ///     should recur every three months, on 23rd of the month, change the value of the recurrence `interval` field to `3`.
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string weeklyByDay { get; set; }

        /// <summary>
        ///     This field is used only if you're scheduling a recurring meeting of type `2` to state which day(s) of the week the
        ///     meeting should recur. The values are: 1 - Sunday; 2 - Monday; 3- Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday;
        ///     7 - Saturday. Multiple values are supported, should be specified separated by comma
        ///     Enum: Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        /// </summary>
        public string weeklyByDays { get; set; }

        /// <summary>
        ///     The supported range is 1-31
        /// </summary>
        public long? monthlyByDay { get; set; }

        /// <summary>
        ///     This field is used only if you're scheduling a recurring meeting of type `3` to state a specific day in a week when
        ///     the monthly meeting should recur; it works together with `MonthlyByWeek` field. The values are: 1 - Sunday; 2 -
        ///     Monday; 3 - Tuesday; 4 - Wednesday; 5 - Thursday; 6 - Friday; 7- Saturday
        /// </summary>
        public long? monthlyByWeekDay { get; set; }

        /// <summary>
        ///     Number of meeting occurrences
        /// </summary>
        public long? count { get; set; }

        /// <summary>
        ///     Meeting expiration datetime
        /// </summary>
        public string until { get; set; }
    }
}