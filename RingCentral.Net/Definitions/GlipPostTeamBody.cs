namespace RingCentral
{
    public class GlipPostTeamBody
    {
        /// <summary>
        /// Team access level.
        /// </summary>
        public bool? @public;

        /// <summary>
        /// Team name.
        /// Required
        /// </summary>
        public string name;

        /// <summary>
        /// Team description.
        /// </summary>
        public string description;

        /// <summary>
        /// List of glip members
        /// </summary>
        public CreateGlipMember[] members;
    }
}