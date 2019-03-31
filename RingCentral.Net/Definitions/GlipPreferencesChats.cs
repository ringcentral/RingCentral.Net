namespace RingCentral
{
    public class GlipPreferencesChats
    {
        /// <summary>
        /// Default: 10
        /// </summary>
        public long? maxCount;

        /// <summary>
        /// Default: CombineAllChatTypes
        /// Enum: SeparateAllChatTypes, SeparateConversationsAndTeams, CombineAllChatTypes
        /// </summary>
        public string leftRailMode;
    }
}