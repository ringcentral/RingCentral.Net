namespace RingCentral
{
    public class GlipChatInfo
    {
        /// <summary>
        /// Internal identifier of a chat
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Type of a chat
        /// Enum: Everyone, Team, Group, Direct, Personal
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// For 'Team' chat type only. Team access level.
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        /// For 'Team','Everyone' chats types only. Chat name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// For 'Team','Everyone' chats types only. Chat description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// For 'Team' chat type only. Team status.
        /// Enum: Active, Archived
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Chat creation datetime in ISO 8601 format
        /// Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        /// Chat last change datetime in ISO 8601 format
        /// Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }

        /// <summary>
        /// </summary>
        public GlipMemberInfo[] members { get; set; }
    }
}