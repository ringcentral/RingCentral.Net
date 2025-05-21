namespace RingCentral
{
    /// <summary>
    ///     Action information
    /// </summary>
    public class CommScreeningActionRequest
    {
        /// <summary>
        ///     Action type
        ///     Required
        ///     Example: ScreeningAction
        ///     Enum: PlayConnectingMessageAction, PlayConnectingPromptAction, PlayWelcomePromptAction, ScreeningAction,
        ///     RingGroupAction, RingAlwaysGroupAction, TerminatingAction
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Screening type
        ///     Required
        ///     Enum: NoCallerId, UnknownCallerId, Always
        /// </summary>
        public string screening { get; set; }

        /// <summary>
        ///     Specifies if an action is enabled
        ///     Required
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Enum: AskToAnswer, PlayCallerNameOnly
        /// </summary>
        public string screeningResult { get; set; }
    }
}