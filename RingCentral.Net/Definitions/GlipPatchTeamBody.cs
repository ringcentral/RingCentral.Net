namespace RingCentral
{
    public class GlipPatchTeamBody
    {
        /// <summary>
        /// Team access level
        /// </summary>
        public bool? @public { get; set; }

        /// <summary>
        /// Team name. Maximum number of characters supported is 250
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Team description. Maximum number of characters supported is 1000
        /// </summary>
        public string description { get; set; }
    }
}