namespace RingCentral
{
    public class TMTeamList
    {
        /// <summary>
        ///     List of teams
        ///     Required
        /// </summary>
        public TMTeamInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public TMNavigationInfo navigation { get; set; }
    }
}