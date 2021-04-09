namespace RingCentral
{
    public class GlipConversationsList
    {
        /// <summary>
        ///     List of conversations
        ///     Required
        /// </summary>
        public GlipConversationInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}