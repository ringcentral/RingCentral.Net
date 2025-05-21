namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommTerminatingActionResource
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
        public CommTerminatingActionResourceTargets[] targets { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string ringingTargetType { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget, ImsVoiceMailTerminatingTarget
        /// </summary>
        public string terminatingTargetType { get; set; }
    }
}