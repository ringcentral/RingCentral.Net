namespace RingCentral
{
    public class TemplateInfo
    {
        /// <summary>
        ///     Link to a template
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a template
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Enum: UserSettings, CallHandling
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Name of a template
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Time of a template creation
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Time of the last template modification
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}