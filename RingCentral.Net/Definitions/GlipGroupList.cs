namespace RingCentral
{
    public class GlipGroupList
    {
        /// <summary>
        ///     List of groups/teams/private chats
        ///     Required
        /// </summary>
        public GlipGroupInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}