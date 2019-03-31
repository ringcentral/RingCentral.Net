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
        /// Identifier(s) of team members.
        /// </summary>
        public object[] members;
    }
}