namespace RingCentral
{
    public class GlipPreferencesChats
    {
        /// <summary>
        /// </summary>
        public long? maxCount { get; set; }

        /// <summary>
        ///     Default: CombineAllChatTypes
        ///     Enum: SeparateAllChatTypes, SeparateConversationsAndTeams, CombineAllChatTypes
        /// </summary>
        public string leftRailMode { get; set; }
    }
}