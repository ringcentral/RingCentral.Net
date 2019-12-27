namespace RingCentral
{
    public class GlipChatInfo
    {
        /// <summary>
        /// Internal identifier of a chat
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a chat
        /// Enum: Everyone, Team, Group, Direct, Personal
        /// </summary>
        public string type;

        /// <summary>
        /// For 'Team' chat type only. Team access level.
        /// </summary>
        public bool? @public;

        /// <summary>
        /// For 'Team','Everyone' chats types only. Chat name.
        /// </summary>
        public string name;

        /// <summary>
        /// For 'Team','Everyone' chats types only. Chat description.
        /// </summary>
        public string description;

        /// <summary>
        /// For 'Team' chat type only. Team status.
        /// Enum: Active, Archived
        /// </summary>
        public string status;

        /// <summary>
        /// Chat creation datetime in ISO 8601 format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Chat last change datetime in ISO 8601 format
        /// </summary>
        public string lastModifiedTime;

        /// <summary>
        /// </summary>
        public GlipMemberInfo[] members;
    }
}