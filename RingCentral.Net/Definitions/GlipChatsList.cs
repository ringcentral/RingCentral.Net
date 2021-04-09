namespace RingCentral
{
    public class GlipChatsList
    {
        /// <summary>
        ///     List of chats
        ///     Required
        /// </summary>
        public GlipChatInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}