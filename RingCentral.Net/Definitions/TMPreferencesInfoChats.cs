namespace RingCentral
{
    public class TMPreferencesInfoChats
    {
        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? maxCount { get; set; }

        /// <summary>
        ///     Default: CombineAllChatTypes
        ///     Enum: SeparateAllChatTypes, SeparateConversationsAndTeams, CombineAllChatTypes
        /// </summary>
        public string leftRailMode { get; set; }
    }
}