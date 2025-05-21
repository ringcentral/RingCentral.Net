namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommTerminatingActionRequest
    {
        /// <summary>
        ///     Action type
        ///     Required
        ///     Example: TerminatingAction
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Action information
        ///     Required
        /// </summary>
        public CommTerminatingActionRequestTargets[] targets { get; set; }

        /// <summary>
        ///     Example: VoiceMailTerminatingTarget
        /// </summary>
        public string ringingTargetType { get; set; }

        /// <summary>
        ///     Example: VoiceMailTerminatingTarget
        /// </summary>
        public string terminatingTargetType { get; set; }
    }
}