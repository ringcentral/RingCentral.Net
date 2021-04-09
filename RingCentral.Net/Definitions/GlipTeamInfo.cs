namespace RingCentral
{
    public class GlipTeamInfo
    {
        /// <summary>
        ///     Internal identifier of a team
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Type of a chat
        ///     Enum: Team
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Team access level
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        ///     Team name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Team description
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Team status
        ///     Enum: Active, Archived
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Team creation datetime in ISO 8601 format
        ///     Format: date-time
        /// </summary>
        public string creationTime { get; set; }

        /// <summary>
        ///     Team last change datetime in ISO 8601 format
        ///     Format: date-time
        /// </summary>
        public string lastModifiedTime { get; set; }
    }
}