namespace RingCentral
{
    public class GlipMessageAttachmentInfoRequest
    {
        /// <summary>
        ///     Type of attachment
        ///     Default: Card
        ///     Enum: Card, Event, Note
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Attachment title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     Default message returned in case the client does not support interactive messages
        /// </summary>
        public string fallback { get; set; }

        /// <summary>
        ///     Color of Event title, including its presentation in Calendar; or the color of the side border of an interactive
        ///     message of a Card. The default color is 'Black'
        /// </summary>
        public string color { get; set; }

        /// <summary>
        ///     Introductory text displayed directly above a message
        /// </summary>
        public string intro { get; set; }

        /// <summary>
        /// </summary>
        public GlipMessageAttachmentAuthorInfo author { get; set; }

        /// <summary>
        ///     Text of attachment (up to 1000 chars), supports GlipDown
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Link to an image displayed at the bottom of a message
        /// </summary>
        public string imageUri { get; set; }

        /// <summary>
        ///     Link to an image preview displayed to the right of a message (82x82)
        /// </summary>
        public string thumbnailUri { get; set; }

        /// <summary>
        ///     Individual subsections within a message
        /// </summary>
        public GlipMessageAttachmentFieldsInfo[] fields { get; set; }

        /// <summary>
        /// </summary>
        public GlipMessageAttachmentFootnoteInfo footnote { get; set; }

        /// <summary>
        ///     Datetime of starting an event
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Datetime of ending an event
        /// </summary>
        public string endTime { get; set; }

        /// <summary>
        ///     Indicates whether an event has some specific time slot or lasts for the whole day(s)
        /// </summary>
        public bool? allDay { get; set; }

        /// <summary>
        ///     Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration:
        ///     1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        ///     Enum: None, Day, Weekday, Week, Month, Year
        /// </summary>
        public string recurrence { get; set; }

        /// <summary>
        ///     Condition of ending an event
        /// </summary>
        public string endingCondition { get; set; }
    }
}