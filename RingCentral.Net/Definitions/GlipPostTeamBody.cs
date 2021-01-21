namespace RingCentral
{
    public class GlipPostTeamBody
    {
        /// <summary>
        /// Team access level.
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        /// Team name.
        /// Required
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Team description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// List of glip members
        /// </summary>
        public CreateGlipMember[] members { get; set; }
    }
}