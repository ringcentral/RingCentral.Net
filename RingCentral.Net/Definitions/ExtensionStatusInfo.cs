namespace RingCentral
{
    public class ExtensionStatusInfo
    {
        /// <summary>
        /// A free-form user comment, describing the status change reason
        /// </summary>
        public string comment;

        /// <summary>
        /// Type of suspension
        /// Enum: Voluntarily, Involuntarily, SuspendedVoluntarily, SuspendedVoluntarily2
        /// </summary>
        public string reason;
    }
}