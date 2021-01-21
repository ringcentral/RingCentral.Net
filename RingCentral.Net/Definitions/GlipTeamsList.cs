namespace RingCentral
{
    public class GlipTeamsList
    {
        /// <summary>
        /// List of teams
        /// Required
        /// </summary>
        public GlipTeamInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}