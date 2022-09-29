namespace RingCentral
{
    public class GlipCreateGroup
    {
        /// <summary>
        ///     Type of a group to be created. 'PrivateChat' is a group of 2 members. 'Team' is a chat of 1 and more participants,
        ///     the membership can be modified in future. 'PersonalChat' is a private chat thread of a user
        ///     Required
        ///     Enum: PrivateChat, Team
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     For 'Team' group type only. Team access level
        /// </summary>
        public bool? isPublic { get; set; }

        /// <summary>
        ///     For 'Team' group type only. Team name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     For 'Team' group type only. Team description
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     “List of glip members. For 'PrivateChat' group type 2 members only are supported”
        /// </summary>
        public GlipMemberInfo[] members { get; set; }
    }
}