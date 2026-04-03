namespace RingCentral
{
    public class TMCreateTeamRequest
    {
        /// <summary>
        ///     Team access level.
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        ///     Team name.
        ///     Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Team description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     Identifier(s) of team members.
        /// </summary>
        public TMCreateTeamRequestMembers[] members { get; set; }
    }
}