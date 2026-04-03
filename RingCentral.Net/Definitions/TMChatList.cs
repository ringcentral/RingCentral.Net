namespace RingCentral
{
    public class TMChatList
    {
        /// <summary>
        ///     List of chats
        ///     Required
        /// </summary>
        public TMChatInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public TMNavigationInfo navigation { get; set; }
    }
}