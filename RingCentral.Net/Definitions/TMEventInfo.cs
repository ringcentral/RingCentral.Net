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
        /// </summary>
        public EventRecurrenceInfo recurrence { get; set; }

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