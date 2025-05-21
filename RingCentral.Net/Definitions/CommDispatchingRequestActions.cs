namespace RingCentral
{
    public class CommDispatchingRequestActions
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
        public CommDispatchingRequestActionsTargets[] targets { get; set; }

        /// <summary>
        ///     Custom start time. Applicable for 'Custom' dispatching type
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? customStartOffset { get; set; }

        /// <summary>
        ///     Duration of calling
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? duration { get; set; }

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