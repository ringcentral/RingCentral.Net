namespace RingCentral
{
    public class TMConversationList
    {
        /// <summary>
        ///     List of conversations
        ///     Required
        /// </summary>
        public TMConversationInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public TMNavigationInfo navigation { get; set; }
    }
}