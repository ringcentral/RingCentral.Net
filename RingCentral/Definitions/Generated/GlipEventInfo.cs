using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipEventInfo : Serializable
    {
        // Internal identifier of an event
        public string id;
        // Internal identifier of a person created an event
        public string creatorId;
        // Event title
        public string title;
        // Datetime of starting an event
        public string startTime;
        // Datetime of ending an event
        public string endTime;
        // Indicates whether an event has some specific time slot or lasts for the whole day(s)
        public bool? allDay;
        // Event recurrence settings
        // Enum: None, Day, Weekday, Week, Month, Year
        public string recurrence;
        // Condition of ending
        public string endingCondition;
        // Count of iterations. For periodic events only
        public long? endingAfter;
        // Iterations end datetime for periodic events
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