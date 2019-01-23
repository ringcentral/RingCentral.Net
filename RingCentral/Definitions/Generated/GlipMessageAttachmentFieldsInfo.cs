using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipMessageAttachmentFieldsInfo : Serializable
    {
        // Title of an individual field
        public string title;
        // Value of an individual field (supports Markdown)
        public string value;
        // Style of width span applied to a field
        // Enum: Short, Long
        public string style;
    }
}