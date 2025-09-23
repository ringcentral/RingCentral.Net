namespace RingCentral
{
    public class CommInteractionDispatchingResourceActions
    {
        /// <summary>
        ///     Action type
        ///     Example: TerminatingAction
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CommGreetingResource greeting { get; set; }

        /// <summary>
        ///     Specifies if an action is enabled
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Screening type
        ///     Enum: NoCallerId, UnknownCallerId, Always
        /// </summary>
        public string screening { get; set; }

        /// <summary>
        ///     Enum: AskToAnswer, PlayCallerNameOnly
        /// </summary>
        public string screeningResult { get; set; }

        /// <summary>
        ///     Action information
        /// </summary>
        public CommInteractionDispatchingResourceActionsTargets[] targets { get; set; }

        /// <summary>
        ///     Custom start time in seconds. Applicable for 'Custom' dispatching type
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? customStartOffset { get; set; }

        /// <summary>
        ///     Duration of calling in seconds
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? duration { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string ringingTargetType { get; set; }

        /// <summary>
        ///     Terminating target type
        ///     Enum: ExtensionTerminatingTarget, PhoneNumberTerminatingTarget, PlayAnnouncementTerminatingTarget,
        ///     VoiceMailTerminatingTarget
        /// </summary>
        public string terminatingTargetType { get; set; }
    }
}