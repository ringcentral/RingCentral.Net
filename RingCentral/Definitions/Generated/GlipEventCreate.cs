namespace RingCentral
{
    public class GlipEventCreate : Serializable
    {
        // Internal identifier of an event
        public string id;

        // Internal identifier of a person created an event
        public string creatorId;

        // Event title
        public string title; // Required

        // Datetime of starting an event
        public string startTime; // Required

        // Datetime of ending an event
        public string endTime; // Required

        // Indicates whether event has some specific time slot or lasts for whole day(s)
        public bool? allDay;

        // Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration: 1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        // Enum: None, Day, Weekday, Week, Month, Year
        public string recurrence;

        // Condition of ending
        public string endingCondition;

        // Count of iterations. For periodic events only. Value range is 1 - 10. Must be specified if 'endingCondition' is 'Count'
        public long? endingAfter;

        // Iterations end datetime for periodic events.
        // Enum: None, Count, Date
        public string endingOn;

        // Hex color code, specifying font color of Event title (including its presentation in Calendar)
        // Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        public string color;

        // Event location
        public string location;

        // Event details
        public string description;
    }
}