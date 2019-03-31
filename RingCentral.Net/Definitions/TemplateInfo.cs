namespace RingCentral
{
    public class TemplateInfo
    {
        /// <summary>
        /// Link to a template
        /// </summary>
        public string uri;

        /// <summary>
        /// Internal identifier of a template
        /// </summary>
        public string id;

        /// <summary>
        /// Enum: UserSettings, CallHandling
        /// </summary>
        public string type;

        /// <summary>
        /// Name of a template
        /// </summary>
        public string name;

        /// <summary>
        /// Time of a template creation
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Time of the last template modification
        /// </summary>
        public string lastModifiedTime;
    }
}