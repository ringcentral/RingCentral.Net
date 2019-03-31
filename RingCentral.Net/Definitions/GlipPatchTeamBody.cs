namespace RingCentral
{
    public class GlipPatchTeamBody
    {
        /// <summary>
        /// Team access level
        /// </summary>
        public bool? @public;

        /// <summary>
        /// Team name. Maximum number of characters supported is 250
        /// </summary>
        public string name;

        /// <summary>
        /// Team description. Maximum number of characters supported is 1000
        /// </summary>
        public string description;
    }
}