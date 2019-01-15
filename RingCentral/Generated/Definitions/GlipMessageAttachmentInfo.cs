using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipMessageAttachmentInfo : Serializable
    {
        // Internal identifier of an attachment
        public string id;
        // Type of an attachment
        public string type;
        // A string of default text that will be rendered in the case that the client does not support Interactive Messages
        public string fallback;
        // A pretext to the message
        public string intro;
        // Information about the author
        public GlipMessageAttachmentAuthorInfo author;
        // Message title
        public string title;
        // A large string field (up to 1000 chars) to be displayed as the body of a message (Supports GlipDown)
        public string text;
        // url used to display a single image at the bottom of a message
        public string imageUri;
        // url used to display a thumbnail to the right of a message (82x82)
        public string thumbnailUri;
        // Information on navigation
        public GlipMessageAttachmentFieldsInfo[] fields;
        // Message Footer
        public GlipMessageAttachmentFootnoteInfo footnote;
        // Internal identifier of a person created an event
        public string creatorId;
        // Datetime of starting an event
        public string startTime;
        // Datetime of ending an event
        public string endTime;
        // Indicates whether an event has some specific time slot or lasts for the whole day(s)
        public bool? allDay;
        // Event recurrence settings.
        public string recurrence;
        // Condition of ending
        public string endingCondition;
        // Count of iterations. For periodic events only
        public long? endingAfter;
        // Iterations end datetime for periodic events
        public string endingOn;
        // Hex color code specifying font color of Event title, including its presentation in Calendar; or the color of the side border of an interactive message of a Card
        public string color;
        // Event location
        public string location;
        // Event details
        public string description;
    }
}