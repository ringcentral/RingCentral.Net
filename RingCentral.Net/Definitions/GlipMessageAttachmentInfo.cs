namespace RingCentral
{
    public class GlipMessageAttachmentInfo
    {
        /// <summary>
        /// Internal identifier of an attachment
        /// </summary>
        public string id;

        /// <summary>
        /// Type of an attachment
        /// Default: Card
        /// Enum: Card, Event, Note
        /// </summary>
        public string type;

        /// <summary>
        /// A string of default text that will be rendered in the case that the client does not support Interactive Messages
        /// </summary>
        public string fallback;

        /// <summary>
        /// A pretext to the message
        /// </summary>
        public string intro;

        /// <summary>
        /// Information about the author
        /// </summary>
        public GlipMessageAttachmentAuthorInfo author;

        /// <summary>
        /// Message title
        /// </summary>
        public string title;

        /// <summary>
        /// A large string field (up to 1000 chars) to be displayed as the body of a message (Supports GlipDown)
        /// </summary>
        public string text;

        /// <summary>
        /// Link to an image displayed at the bottom of a message
        /// </summary>
        public string imageUri;

        /// <summary>
        /// Link to an image preview displayed to the right of a message (82x82)
        /// </summary>
        public string thumbnailUri;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public GlipMessageAttachmentFieldsInfo[] fields;

        /// <summary>
        /// Message Footer
        /// </summary>
        public GlipMessageAttachmentFootnoteInfo footnote;

        /// <summary>
        /// Internal identifier of a person created an event
        /// </summary>
        public string creatorId;

        /// <summary>
        /// Datetime of starting an event
        /// </summary>
        public string startTime;

        /// <summary>
        /// Datetime of ending an event
        /// </summary>
        public string endTime;

        /// <summary>
        /// Indicates whether an event has some specific time slot or lasts for the whole day(s)
        /// </summary>
        public bool? allDay;

        /// <summary>
        /// Event recurrence settings.
        /// Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string recurrence;

        /// <summary>
        /// Condition of ending
        /// </summary>
        public string endingCondition;

        /// <summary>
        /// Count of iterations. For periodic events only
        /// </summary>
        public long? endingAfter;

        /// <summary>
        /// Iterations end datetime for periodic events
        /// Default: None
        /// Enum: None, Count, Date
        /// </summary>
        public string endingOn;

        /// <summary>
        /// Color of Event title, including its presentation in Calendar; or the color of the side border of an interactive message of a Card
        /// Default: Black
        /// Enum: Black, Red, Orange, Yellow, Green, Blue, Purple, Magenta
        /// </summary>
        public string color;

        /// <summary>
        /// Event location
        /// </summary>
        public string location;

        /// <summary>
        /// Event details
        /// </summary>
        public string description;
    }
}