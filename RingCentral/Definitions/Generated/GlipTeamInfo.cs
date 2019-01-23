using Newtonsoft.Json;

namespace RingCentral
{
    public class GlipTeamInfo : Serializable
    {
        // Internal identifier of a team
        public string id;
        // Type of a chat
        // Enum: Team
        public string type;
        // Team access level
        public bool? @public;
        // Team name
        public string name;
        // Team description
        public string description;
        // Team status
        // Enum: Active, Archived
        public string status;
        // Team creation datetime in ISO 8601 format
        public string creationTime;
        // Team last change datetime in ISO 8601 format
        public string lastModifiedTime;
    }
}