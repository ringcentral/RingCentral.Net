namespace RingCentral
{
    public class ExtensionStatusInfo : Serializable
    {
        // A free-form user comment, describing the status change reason
        public string comment;
        // Type of suspension
        // Enum: Voluntarily, Involuntarily
        public string reason;
    }
}