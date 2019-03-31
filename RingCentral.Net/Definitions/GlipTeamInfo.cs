namespace RingCentral
{
    public class GlipTeamInfo
    {
        /// <summary>
        /// Internal identifier of a team
        /// </summary>
        public string id;

        /// <summary>
        /// Type of a chat
        /// Enum: Team
        /// </summary>
        public string type;

        /// <summary>
        /// Team access level
        /// </summary>
        public bool? @public;

        /// <summary>
        /// Team name
        /// </summary>
        public string name;

        /// <summary>
        /// Team description
        /// </summary>
        public string description;

        /// <summary>
        /// Team status
        /// Enum: Active, Archived
        /// </summary>
        public string status;

        /// <summary>
        /// Team creation datetime in ISO 8601 format
        /// </summary>
        public string creationTime;

        /// <summary>
        /// Team last change datetime in ISO 8601 format
        /// </summary>
        public string lastModifiedTime;
    }
}