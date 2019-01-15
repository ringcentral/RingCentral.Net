using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class GlipCreateGroup : Serializable
    {
        // Type of a group to be created. 'PrivateChat' is a group of 2 members. 'Team' is a chat of 1 and more participants, the membership can be modified in future. 'PersonalChat' is a private chat thread of a user
        // Enum: PrivateChat, Team
        public string type; // Required
        // For 'Team' group type only. Team access level
        public bool? isPublic;
        // For 'Team' group type only. Team name
        public string name;
        // For 'Team' group type only. Team description
        public string description;
        // Identifier(s) of group members. For 'PrivateChat' group type 2 members only are supported
        public string[] members;
    }
}