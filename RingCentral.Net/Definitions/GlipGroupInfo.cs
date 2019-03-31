namespace RingCentral
{
    public class GlipGroupInfo
    {
        /* Internal identifier of a group */
        public string id;

        /* Type of a group. 'PrivateChat' is a group of 2 members. 'Group' is a chat of 2 and more participants, the membership cannot be changed after group creation. 'Team' is a chat of 1 and more participants, the membership can be modified in future. 'PersonalChat' is a private chat thread of a user */
        // Enum: PrivateChat, Group, Team, PersonalChat
        public string type;

        /* For 'Team' group type only. Team access level */
        public bool? isPublic;

        /* For 'Team' group type only. Team name */
        public string name;

        /* For 'Team' group type only. Team description */
        public string description;

        /* Identifier(s) of group members */
        public string[] members;

        /* Group creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format */
        public string creationTime;

        /* Group last change datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format */
        public string lastModifiedTime;
    }
}