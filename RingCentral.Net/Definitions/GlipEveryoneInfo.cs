namespace RingCentral
{
    public class GlipEveryoneInfo
    {
        /// <summary>
        /// Internal identifier of a chat
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a chat
        /// Enum: Everyone
        /// </summary>
        public string type;

        /// <summary>
        /// Chat name
        /// </summary>
        public string name;

        /// <summary>
        /// Chat description
        /// </summary>
        public string description;

        /// <summary>
        /// Chat creation datetime in ISO 8601 format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Chat last change datetime in ISO 8601 format
        /// </summary>
        public string lastModifiedTime;
    }
}