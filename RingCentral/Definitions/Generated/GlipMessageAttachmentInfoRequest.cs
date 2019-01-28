namespace RingCentral
{
    public class GlipMessageAttachmentInfoRequest
    {
        // Type of attachment
        // Enum: Card, Event, Note
        public string type;

        // Attachment title
        public string title;

        // Default message returned in case the client does not support interactive messages
        public string fallback;

        // Hex color code specifying font color of Event title, including its presentation in Calendar; or the color of the side border of an interactive message of a Card
        // Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        public string color;

        // Introductory text displayed directly above a message
        public string intro;

        // Information about the author
        public GlipMessageAttachmentAuthorInfo author;

        // Text of attachment (up to 1000 chars), supports GlipDown
        public string text;

        // Link to an image displayed at the bottom of a message
        public string imageUri;

        // Link to an image preview displayed to the right of a message (82x82)
        public string thumbnailUri;

        // Individual subsections within a message
        public GlipMessageAttachmentFieldsInfo[] fields;

        // Message footer information
        public GlipMessageAttachmentFootnoteInfo footnote;

        // Datetime of starting an event
        public string startTime;

        // Datetime of ending an event
        public string endTime;

        // Indicates whether an event has some specific time slot or lasts for the whole day(s)
        public bool? allDay;

        // Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration: 1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        // Enum: None, Day, Weekday, Week, Month, Year
        public string recurrence;

        // Condition of ending an event
        public string endingCondition;
    }
}