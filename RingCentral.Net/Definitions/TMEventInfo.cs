namespace RingCentral
{
    public class TMEventInfo
    {
        /// <summary>
        ///     Internal identifier of an event
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of a person created an event
        /// </summary>
        public string creatorId { get; set; }

        /// <summary>
        ///     Event title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Datetime of starting an event
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Datetime of ending an event
        ///     Format: date-time
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        ///     Indicates whether an event has some specific time slot or lasts for the whole day(s)
        /// </summary>
        public bool? allDay { get; set; }

        /// <summary>
        ///     Event recurrence settings
        ///     Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string recurrence { get; set; }

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
        ///     Iterations ending datetime for periodic events in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        ///     Format: date-time
        /// </summary>
        public string endingOn { get; set; }

        /// <summary>
        ///     Color of Event title (including its presentation in Calendar)
        ///     Default: Black
        ///     Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color { get; set; }

        /// <summary>
        ///     Event location
        /// </summary>
        public string location { get; set; }

        /// <summary>
        ///     Event details
        /// </summary>
        public string description { get; set; }
    }
}