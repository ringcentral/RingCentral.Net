namespace RingCentral
{
    public class EveryoneTeamInfo
    {
        /// <summary>
        ///     Internal identifier of a chat
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of chat
        ///     Enum: Everyone
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Chat name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Chat description
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Chat creation datetime in ISO 8601 format
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Chat last change datetime in ISO 8601 format
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}