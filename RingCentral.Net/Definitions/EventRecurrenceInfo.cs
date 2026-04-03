namespace RingCentral
{
    public class EventRecurrenceInfo
    {
        /// <summary>
        ///     Event recurrence settings. For non-periodic events the value
        ///     is `None`. Must be greater or equal to event duration: 1- Day/Weekday;
        ///     7 - Week; 28 - Month; 365 - Year
        ///     Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string schedule { get; set; }

        /// <summary>
        ///     Condition of ending an event
        ///     Enum: None, Count, Date
        /// </summary>
        public string endingCondition { get; set; }

        /// <summary>
        ///     Count of event iterations. For periodic events only. Value range is 1 - 10.
        ///     Must be specified if `endingCondition` is `Count`
        ///     Format: int32
        /// </summary>
        public long? endingAfter { get; set; }

        /// <summary>
        ///     Iterations ending datetime for periodic events in
        ///     [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string endingOn { get; set; }
    }
}